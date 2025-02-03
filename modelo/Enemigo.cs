using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SpaceInvaders.vista;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Drawing;
using System.Media;

public class Enemigo {
    private Vista vista;
    private PictureBox enemigo;
    private int probabilidad;
    private SoundPlayer play;

    public Enemigo(Vista vista, int posX, int posY,int probabilidad) {
        this.vista = vista;
       
        this.probabilidad = probabilidad;   
        this.enemigo = new PictureBox();
        this.vista.panelJuego.Controls.Add(enemigo);
        play = new SoundPlayer(@"..\\..\\Resources\\laserEnemigo.wav");

        enemigo.Location = new System.Drawing.Point(posX, posY);
        enemigo.Width = 50;
        enemigo.Height = 50;
        enemigo.SizeMode = PictureBoxSizeMode.StretchImage;
        enemigo.Image = SpaceInvaders.Properties.Resources.enem1;

        
    }
    public int movimientoLateral(int direccion ) {
        enemigo.Left += direccion;

        if (enemigo.Left < 14 || enemigo.Left > 1036) {
            direccion = direccion * -1;

        }
        return direccion;
    }

    public void saltarLinea() {
        enemigo.Top += 50;
    }

    public PictureBox getEnemigo() {
        return enemigo;
    }

    public void destruir(int puntos) {
        play.SoundLocation = @"..\\..\\Resources\\muerteEnemiga.wav";
        play.Load();
        play.Play();
        enemigo.Dispose();
        vista.lblPuntos.Text = (int.Parse(vista.lblPuntos.Text) + puntos).ToString();

       

    }

    public void generarDisparo(int velocidad,int limite) {
        int num = 0;
        Random rnd = new Random();
        num = rnd.Next(1, 1001/*1001*/);
        if (num<=probabilidad && vista.disparosEnemigos.Count<limite){
            play.Play();    
            DisparoEnemigo disparo = new DisparoEnemigo(vista, enemigo.Location.X + 21, enemigo.Location.Y + 50,velocidad);
            vista.disparosEnemigos.Add(disparo);
        }
    }

    public void setProbabilidad(int probabilidad) {
        this.probabilidad = probabilidad;
    }
    public int getProbabilidad() {
        return probabilidad;
    }
}

