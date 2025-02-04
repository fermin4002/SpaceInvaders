using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using SpaceInvaders.vista;
using System.Media;
using System.Globalization;
using System.Text.Json;




public class Controlador {
    List<Partida> partidas;
    private Vista vista;
    private int velocicadDisparo;
    private GestorComponentes gestor;
    private SoundPlayer player, tiro;


    public Controlador(Vista vista) {
        partidas = new List<Partida>();
        this.vista = vista;
        vista.KeyPreview = true;

        player = new SoundPlayer(@"..\\..\\Resources\\transportar.wav");
        tiro = new SoundPlayer(@"..\\..\\Resources\\laser.wav");


        vista.KeyDown += keyDown;
        vista.btnClasificacion.Click += pulsarBoton;
        vista.btnStart.Click += pulsarBoton;
        vista.btnSalir.Click += pulsarBoton;
        vista.btnMenuExit.Click += pulsarBoton;


        velocicadDisparo = 10;


        leerTXT();
        menu();

    }

    public void partida() {
        cargarInfo();
        crearEnemigos(30);
        crearDefensas();

        this.gestor = new GestorComponentes(vista, this);
        vista.personaje = new Personaje(vista, 10);
    }

    public void crearEnemigos(int probabilidad) {
        int valX = 255;
        int valY = 90;
        for (int y = 0; y < 3 /*4*/; y++) {
            for (int x = 0; x < 10/*10*/; x++) {
                Enemigo enemigo = new Enemigo(vista, valX + x * 10, valY + y * 10, probabilidad);
                vista.enemigos.Add(enemigo);
                valX += 50;
            }
            valX = 255;
            valY += 50;
        }
    }

    public void crearDefensas() {
        //60 separacion 90:60
        int valX = 205;
        for (int i = 0; i < 5; i++) {
            Defensa defensa = new Defensa(vista, valX + i * 60, 500);
            vista.defensas.Add(defensa);
            valX += 90;
        }
    }

    public void keyDown(object sender, KeyEventArgs e) {
        switch (e.KeyCode) {
            case Keys.Left:
            Console.WriteLine("Izquierda");
            vista.personaje.moverIzq();

            break;
            case Keys.Right:
            Console.WriteLine("Derecha");
            vista.personaje.moverDer();
            break;
            case Keys.Space:
            Console.WriteLine("Disparo");
            if (vista.disparos.Count < 1) {
                Disparo tiro = new Disparo(this.vista, vista.personaje.getPersonaje().Location.X + 19, vista.personaje.getPersonaje().Location.Y - 24, velocicadDisparo);
                this.tiro.Play();
                this.vista.disparos.Add(tiro);
            }
            break;

        }

    }


    public void pulsarBoton(object sender, EventArgs e) {
        if (sender is Button btn) {
            switch (btn.Name) {
                case "btnStart":
                Console.WriteLine("btnStart");
                juego();
                partida();
                break;
                case "btnClasificacion":
                Console.WriteLine("btnClasificacion");
                ranking();
                break;
                case "btnSalir":
                Console.WriteLine("btnSalir");
                menu();
                break;
                case "btnMenuExit":
                if (!vista.txtNombre.Text.Equals("")) {
                    String nombre = vista.txtNombre.Text;
                    int puntos = int.Parse(vista.lblPuntosGameOver.Text);
                    partidas.Add(new Partida(nombre, puntos));
                    vista.txtNombre.Text = "";

                }
                player.Play();
                menu();
                break;
                default:
                Console.WriteLine(sender.GetHashCode());

                break;
            }
        }
    }

    public void juego() {
        player.Play();
        vista.KeyPreview = true;//Capturar las teclas
        vista.panelJuego.Visible = true;
        vista.panelJuego.Enabled = true;

        vista.panelVidasPunto.Visible = true;
        vista.panelVidasPunto.Enabled = true;

        vista.panelMenu.Visible = false;
        vista.panelMenu.Enabled = false;

        vista.panelRanking.Visible = false;
        vista.panelRanking.Enabled = false;

        vista.panelGameOver.Visible = false;
        vista.panelGameOver.Enabled = false;
    }

    public void menu() {

        vista.KeyPreview = false;
        vista.panelMenu.Visible = true;
        vista.panelMenu.Enabled = true;

        vista.panelRanking.Visible = false;
        vista.panelRanking.Enabled = false;

        vista.panelJuego.Visible = false;
        vista.panelJuego.Enabled = false;

        vista.panelVidasPunto.Visible = false;
        vista.panelVidasPunto.Enabled = false;

        vista.panelGameOver.Visible = false;
        vista.panelGameOver.Enabled = false;
    }

    public void ranking() {

        vista.KeyPreview = false;
        cargarListView();
        vista.panelRanking.Visible = true;
        vista.panelRanking.Enabled = true;

        vista.panelMenu.Visible = false;
        vista.panelMenu.Enabled = false;

        vista.panelJuego.Visible = false;
        vista.panelJuego.Enabled = false;

        vista.panelVidasPunto.Visible = false;
        vista.panelVidasPunto.Enabled = false;

        vista.panelGameOver.Visible = false;
        vista.panelGameOver.Enabled = false;

    }


    public void gameOver() {
        vista.KeyPreview = false;
        vista.panelRanking.Visible = false;
        vista.panelRanking.Enabled = false;

        vista.panelMenu.Visible = false;
        vista.panelMenu.Enabled = false;

        vista.panelJuego.Visible = false;
        vista.panelJuego.Enabled = false;

        vista.panelVidasPunto.Visible = false;
        vista.panelVidasPunto.Enabled = false;

        vista.panelGameOver.Visible = true;
        vista.panelGameOver.Enabled = true;
        vista.panelGameOver.BringToFront();

        vista.lblPuntosGameOver.Text = vista.lblPuntos.Text;
    }

    public void cargarInfo() {
        vista.lblPuntos.Text = "0";
        vista.lblVidas.Text = "VIDAS:3";
    }

    public int getVelocidadDisparo() {
        return this.velocicadDisparo;
    }

    public void setVelocidadDisparo(int velocidadDisparo) {
        this.velocicadDisparo = velocidadDisparo;
    }

    public void cargarListView() {
        vista.rankingPuntos.Items.Clear();
        List<(string Nombre, int Puntuacion)> jugadores = new List<(string Nombre, int Puntuacion)>();
        int i = 1;
        foreach(var clave in partidas) {
            jugadores.Add((clave.Nombre,clave.Puntuacion));
        }
        jugadores.Sort((x, y) => y.Puntuacion.CompareTo(x.Puntuacion));
        foreach ((string Nombre, int Puntuacion) jugador in jugadores) {
            string[] row = { i.ToString(), jugador.Nombre, jugador.Puntuacion.ToString() };
            vista.rankingPuntos.Items.Add(new ListViewItem(row));
            i++;
        }

    }

    public SoundPlayer getTiro() {
        return tiro;
    }
    
    public void leerTXT() {
        string ruta = @"..\\..\\Resources\\ranking.json";
        string jsonString = File.ReadAllText(ruta);

        // Deserializar el JSON en una lista de objetos Partida
        partidas = JsonSerializer.Deserialize<List<Partida>>(jsonString);
    }

    public void crearJson() {
        string jsonString = JsonSerializer.Serialize(partidas, new JsonSerializerOptions { WriteIndented = true });

        // Guardar en un archivo
        File.WriteAllText(@"..\\..\\Resources\\ranking.json", jsonString);

        
    }
}

