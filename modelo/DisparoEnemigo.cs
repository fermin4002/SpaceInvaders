using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceInvaders.vista;
public class DisparoEnemigo  {
    private Vista vista;
    private PictureBox tiro;
    private int velocidad;
    public DisparoEnemigo(Vista vista, int posX, int posY,int velocidad) {
   
        this.vista=vista;
        this.velocidad = velocidad;
        this.tiro = new System.Windows.Forms.PictureBox();
        this.vista.panelJuego.Controls.Add(tiro);
        tiro.Location = new System.Drawing.Point(posX, posY);
        tiro.Width = 12;
        tiro.Height = 24;

        tiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        tiro.Image = SpaceInvaders.Properties.Resources.tiroEnemigo;

    }

    public void moverTiroEnemigo() {
        if (tiro.Top < 600) {
            tiro.Top += velocidad;
        } else {
            vista.disparosEnemigos.Remove(this);
            vista.panelJuego.Controls.Remove(tiro);
        }
    }

    public PictureBox getTiro() {
        return tiro;
    }

     public void destruir() {
        tiro.Dispose();
    }
}

