using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceInvaders.vista;

public class GestorComponentes {
    private Vista vista;
    private Controlador controlador;
    //Listas pre-eliminacion
    private List<Enemigo> enemigos;
    private List<Disparo> disparos;
    private List<DisparoEnemigo> disparosEnemigos;
    private List<Defensa> defensa;

    private System.Windows.Forms.Timer timerEnemigos;
    private System.Windows.Forms.Timer timerTiros;
    private System.Windows.Forms.Timer timerAnimacion;
    private System.Windows.Forms.Timer timerColisionPersonajeEnemigo;
    private System.Windows.Forms.Timer timerColisionDisparoPersonajeEnemigo;
    private System.Windows.Forms.Timer timerColisionEnemigoDefensa;
    private System.Windows.Forms.Timer timerColisionDisparoPersonajeDefensa;
    private System.Windows.Forms.Timer timerColisionDisparoEnemigoPersonaje;
    private System.Windows.Forms.Timer timerColisionDisparoEnemigoDefensa;
    private int direccionGlobal;

    private int pasoAnimacion ;

    private int velocidadDisparo;
    private int probabilidadDisparo;
    private int puntos;
    private int limite;

    public GestorComponentes(Vista vista,Controlador controlador) {
        this.controlador = controlador;
        this.vista = vista;
        this.pasoAnimacion = 1;

        this.velocidadDisparo = 10;
        this.direccionGlobal = 10;
        this.probabilidadDisparo = 30;
        this.puntos = 20;
        this.limite = 10;

        this.enemigos = new List<Enemigo>();
        this.disparos = new List<Disparo>();
        this.disparosEnemigos = new List<DisparoEnemigo>();
        this.defensa = new List<Defensa>();
        
        
       
        this.timerEnemigos = new System.Windows.Forms.Timer();
        this.timerEnemigos.Interval = 500;
        this.timerEnemigos.Tick += (sender, e) => moverEnemigos();
        this.timerEnemigos.Start();

        
        this.timerAnimacion = new System.Windows.Forms.Timer();
        this.timerAnimacion.Interval = 100;
        this.timerAnimacion.Tick += (sender, e) => animaciones(pasoAnimacion);
        this.timerAnimacion.Start();

        this.timerTiros = new System.Windows.Forms.Timer();
        this.timerTiros.Interval = 50;
        this.timerTiros.Tick += (sender, e) => moverTiros();
        this.timerTiros.Start();

        this.timerColisionPersonajeEnemigo = new System.Windows.Forms.Timer();
        this.timerColisionPersonajeEnemigo.Interval = 1;
        this.timerColisionPersonajeEnemigo.Tick += (sender, e) => colisionPersonajeEnemigo();
        this.timerColisionPersonajeEnemigo.Start();

        this.timerColisionDisparoPersonajeEnemigo = new System.Windows.Forms.Timer();
        this.timerColisionDisparoPersonajeEnemigo.Interval = 1;
        this.timerColisionDisparoPersonajeEnemigo.Tick += (sender, e) => colisionEnemigoDisparo();
        this.timerColisionDisparoPersonajeEnemigo.Start();

        this.timerColisionEnemigoDefensa = new System.Windows.Forms.Timer();
        this.timerColisionEnemigoDefensa.Interval = 1;
        this.timerColisionEnemigoDefensa.Tick += (sender, e) => colisionEnemigoDefensa();
        this.timerColisionEnemigoDefensa.Start();

        this.timerColisionDisparoPersonajeDefensa = new System.Windows.Forms.Timer();
        this.timerColisionDisparoPersonajeDefensa.Interval = 1;
        this.timerColisionDisparoPersonajeDefensa.Tick += (sender, e) => colisionTiroPersonajeDefensa ();
        this.timerColisionDisparoPersonajeDefensa.Start();

        this.timerColisionDisparoEnemigoPersonaje = new System.Windows.Forms.Timer();
        this.timerColisionDisparoEnemigoPersonaje.Interval = 1;
        this.timerColisionDisparoEnemigoPersonaje.Tick += (sender, e) => colisionDisparoEnemigoPersonaje();
        this.timerColisionDisparoEnemigoPersonaje.Start();

        this.timerColisionDisparoEnemigoDefensa = new System.Windows.Forms.Timer();
        this.timerColisionDisparoEnemigoDefensa.Interval = 1;
        this.timerColisionDisparoEnemigoDefensa.Tick += (sender, e) => colisionDisparosEnemigosDefensa();
        this.timerColisionDisparoEnemigoDefensa.Start();

    }

    private void moverEnemigos() {
        int direccionTemp;
        for (int i= vista.enemigos.Count-1; i> -1;i--) {
            direccionTemp = direccionGlobal;
            direccionGlobal = vista.enemigos[i].movimientoLateral(direccionGlobal);
            vista.enemigos[i].generarDisparo(velocidadDisparo,limite);
            if (direccionTemp != direccionGlobal) {
                for (int t=vista.enemigos.Count-1; t>-1;t--) {
                    vista.enemigos[t].saltarLinea();
                }
                i++;
            }
        }
    }

    private void moverTiros() {
        if (vista.disparos.Count == 1) {
            vista.disparos[0].moverTiro();
        }
        if (vista.disparosEnemigos.Count > 0) {
            for (int i = vista.disparosEnemigos.Count-1; i > -1; i--) {
                vista.disparosEnemigos[i].moverTiroEnemigo();
            }
        }

    }

    public void animaciones(int i) {
        
            switch (i) {
                case 1:
                    vista.personaje.getPersonaje().Image = SpaceInvaders.Properties.Resources.nave1;
                    foreach(var enemigo in vista.enemigos) {
                        enemigo.getEnemigo().Image = SpaceInvaders.Properties.Resources.enem1;
                    }
            break;
                case 2:
            vista.personaje.getPersonaje().Image = SpaceInvaders.Properties.Resources.nave2;
                foreach (var enemigo in vista.enemigos) {
                    enemigo.getEnemigo().Image = SpaceInvaders.Properties.Resources.enem2;
                }
            break;
                case 3:
            vista.personaje.getPersonaje().Image = SpaceInvaders.Properties.Resources.nave3;
                foreach (var enemigo in vista.enemigos) {
                    enemigo.getEnemigo().Image = SpaceInvaders.Properties.Resources.enem1;
                }
            break;
                case 4:
                foreach (var enemigo in vista.enemigos) {
                    enemigo.getEnemigo().Image = SpaceInvaders.Properties.Resources.enem2;
                }
            vista.personaje.getPersonaje().Image = SpaceInvaders.Properties.Resources.nave2;
            break;
            }

            this.pasoAnimacion++;
            if (this.pasoAnimacion == 5) {
                this.pasoAnimacion = 1;
            }

        
    }

    public void colisionEnemigoDisparo() {
        //Colisiones enemigos-tiros
        bool salir = false;
        if (vista.disparos.Count > 0) {
            int i = vista.enemigos.Count - 1;
            
            while ( i > -1 && !salir) {
                Disparo tirito = vista.disparos[0];
                if (tirito.getTiro().Bounds.IntersectsWith(vista.enemigos[i].getEnemigo().Bounds)) {
                    tirito.destruir();
                    vista.enemigos[i].destruir(puntos);
                    enemigos.Add(vista.enemigos[i]);
                    salir = true;   
                }
                i--;    
            }
        }
        limpiarEnemigos();
        limpiaDisparos();
        if (vista.enemigos.Count == 0 && salir) {
            siguienteNivel();
        }
    }

    public void colisionEnemigoDefensa() {
        //Colisiones enemigos-defensas
        int i = vista.enemigos.Count - 1;
        Boolean salir = false;
        while ( i > -1 && !salir) {
         
            int t = vista.defensas.Count - 1;
            while ( t > -1 && !salir) {
                if (vista.enemigos[i].getEnemigo().Bounds.IntersectsWith(vista.defensas[t].getDefensa().Bounds)) {
                    vista.enemigos[i].destruir(puntos);
                    vista.defensas[t].destruir(vista.defensas[t].getVidas());
                    enemigos.Add(vista.enemigos[i]);
                    if (vista.defensas[t].getVidas() == 0) {
                        defensa.Add(vista.defensas[t]);
                    }
                    salir = true;
                   
                }
                t--;
            }
            i--;
        }
        limpiarEnemigos();
        limpiarDefensas();
        if (vista.enemigos.Count == 0 && salir) {
            siguienteNivel();
        }
    }



    public void colisionDisparoEnemigoPersonaje() {
        //Colisiones disparosEnemigos-personaje
        int i = vista.disparosEnemigos.Count - 1;
        Boolean salir = false;
        while ( i > -1 && !salir) {
            if (vista.disparosEnemigos[i].getTiro().Bounds.IntersectsWith(vista.personaje.getPersonaje().Bounds)) {
                vista.disparosEnemigos[i].destruir();
                vista.personaje.destruir(1);
                if (vista.personaje.getVida() == 0) {
                    pararTimers();
                    finPartida();
                    limpiarCampos();
                    controlador.gameOver();
                }
                salir = true;
                //MessageBox.Show("Has perdido");
            }
            i--;
        }
        limpiaDisparos();
        limpiarDisparosEnemigos();
    }

    public void colisionDisparosEnemigosDefensa() {
        //Colisiones disparosEnemigos-defensas
        int i= vista.disparosEnemigos.Count - 1;
        Boolean salir = false;
        while (i > -1 && !salir) {
            int t = vista.defensas.Count - 1;
            while ( t > -1 && !salir) {
                if (vista.disparosEnemigos[i].getTiro().Bounds.IntersectsWith(vista.defensas[t].getDefensa().Bounds)) {
                    vista.disparosEnemigos[i].destruir();
                    disparosEnemigos.Add(vista.disparosEnemigos[i]);
                    vista.defensas[t].destruir(1);
                    if (vista.defensas[t].getVidas() == 0) {
                        defensa.Add(vista.defensas[t]);
                    }
                    salir = true;
                }
                t--;
            }
            i--;
        }
        limpiarDisparosEnemigos();
        limpiarDefensas();
    }



    public void colisionTiroPersonajeDefensa() {
        //colisiones disparos-personaje/defensas
        if (vista.disparos.Count > 0) {
            int i = vista.defensas.Count - 1;
            Boolean salir = false;
            while ( i > -1 &&  !salir) {
                Disparo tirito = vista.disparos[0];
                if (tirito.getTiro().Bounds.IntersectsWith(vista.defensas[i].getDefensa().Bounds)) {
                    salir = true;
                    tirito.destruir();
                    vista.defensas[i].destruir(1);
                    if(vista.defensas[i].getVidas() == 0) {
                        defensa.Add(vista.defensas[i]);
                    }
                    
                }
                i--;
            }
        }
        limpiarDefensas();
        limpiaDisparos();
    }

    public void colisionPersonajeEnemigo() {
        //colisiones personaje-enemigos
        int i = vista.enemigos.Count - 1;
        Boolean salir = false;
        while (i > -1 && !salir) {
            if (vista.enemigos[i].getEnemigo().Bounds.IntersectsWith(vista.personaje.getPersonaje().Bounds)) {
                vista.personaje.destruir(vista.personaje.getVida());
                vista.enemigos[i].destruir(puntos);
                enemigos.Add(vista.enemigos[i]);
                if (vista.personaje.getVida() == 0) {
                    pararTimers();
                    finPartida();
                    limpiarCampos();
                    controlador.gameOver();
                }
                salir = true;

            }
            i--;
        }
        limpiarEnemigos();  
        limpiaDisparos();
    }

    public void limpiarDisparosEnemigos() {

        foreach(DisparoEnemigo clave in disparosEnemigos) {
            vista.disparosEnemigos.Remove(clave);
        }
        disparosEnemigos.Clear();
    }

    public void limpiarEnemigos() {
        foreach (Enemigo clave in enemigos) {
            vista.enemigos.Remove(clave);
        }
        enemigos.Clear();
    }
    public void limpiarDefensas() {
        foreach (Defensa clave in defensa) {
            vista.defensas.Remove(clave);
        }
        defensa.Clear();
    }
    public void limpiaDisparos() {
        if (disparos.Count > 0) {
            vista.disparos.Remove(disparos[0]);
            disparos.Clear();
        } 
    }
    
    public void limpiarCampos() {
        vista.disparosEnemigos.Clear();
        vista.disparos.Clear();
        vista.enemigos.Clear();
        vista.defensas.Clear();
        
        defensa.Clear();
        disparos.Clear();
        disparosEnemigos.Clear();
        enemigos.Clear();

    }
    public void pararTimers() {

        timerEnemigos.Stop();
        timerTiros.Stop();
        timerAnimacion.Stop();
        timerColisionPersonajeEnemigo.Stop();
        timerColisionDisparoPersonajeEnemigo.Stop();
        timerColisionEnemigoDefensa.Stop();
        timerColisionDisparoPersonajeDefensa.Stop();
        timerColisionDisparoEnemigoPersonaje.Stop();
        timerColisionDisparoEnemigoDefensa.Stop();    
        vista.panelJuego.Controls.Clear();
        




    }

    public void reanudarTimers() {
        timerEnemigos.Start();
        timerTiros.Start();
        timerAnimacion.Start();
        timerColisionPersonajeEnemigo.Start();
        timerColisionDisparoPersonajeEnemigo.Start();
        timerColisionEnemigoDefensa.Start();
        timerColisionDisparoPersonajeDefensa.Start();
        timerColisionDisparoEnemigoPersonaje.Start();
        timerColisionDisparoEnemigoDefensa.Start();
    }
    public void siguienteNivel() {
        vista.KeyPreview = false;
        pararTimers();
        vista.defensas.Clear();
        vista.enemigos.Clear();
        vista.disparos.Clear();
        vista.disparosEnemigos.Clear();
        
        direccionGlobal=Math.Abs(direccionGlobal);
        velocidadDisparo += 5;
        direccionGlobal += 5;
        probabilidadDisparo += 10;
        puntos += 10;
        limite += 5;

        controlador.crearEnemigos(probabilidadDisparo,direccionGlobal);
        vista.personaje.setPaso(direccionGlobal);
        controlador.setVelocidadDisparo(velocidadDisparo);
        controlador.crearDefensas();
        vista.KeyPreview = true;
        vista.personaje.getPersonaje().BringToFront();
        int vida=vista.personaje.getVida();
        vista.personaje = new Personaje(vista, direccionGlobal);
        vista.personaje.setVida(vida);
        vista.lblVidas.Text = "VIDAS:" + vista.personaje.getVida().ToString();
        reanudarTimers();

    }
    public void finPartida() {
        velocidadDisparo = 5;
        direccionGlobal = 10;
        probabilidadDisparo = 30;
        puntos = 20;
        limite = 10;
        vista.personaje.setPaso(10);
        controlador.setVelocidadDisparo(10);
    }

}

