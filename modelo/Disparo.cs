using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceInvaders.vista;

public class Disparo {
    protected Vista vista;

    private int velocidad;
    protected PictureBox tiro;

    public Disparo(Vista vista,int posX,int posY,int velocidad){

        this.velocidad = velocidad;
        this.vista = vista;
        this.tiro = new PictureBox();
        this.vista.panelJuego.Controls.Add(tiro);
        tiro.Location = new System.Drawing.Point(posX, posY);
        tiro.Width = 12;
        tiro.Height = 24;
           
        tiro.SizeMode = PictureBoxSizeMode.StretchImage;
        tiro.Image = SpaceInvaders.Properties.Resources.tiro;
  
    }
    

    public void destruir() {

        tiro.Dispose();
        //tiro.
        vista.panelJuego.Controls.Remove(tiro);
        vista.disparos.Remove(this);
        
       
    }
   

    public void moverTiro() {

        if(tiro.Top >0 ) {
            tiro.Top -= velocidad;
        } else {
            tiro.Dispose();
            vista.panelJuego.Controls.Remove(tiro);
            vista.disparos.Remove(this);
        }
    }

    public PictureBox getTiro() {
        return tiro;
    }
}

