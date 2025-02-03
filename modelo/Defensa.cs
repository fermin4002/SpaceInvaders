using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceInvaders.vista;
public class Defensa{
    private Vista vista;
    private PictureBox defensa;
    private int vidas;

    public Defensa(Vista vista,int x, int y) {
        this.vidas = 3;
        this.vista = vista;
        this.defensa = new PictureBox();
        this.vista.panelJuego.Controls.Add(defensa);
        defensa.Location = new System.Drawing.Point(x, y);
        defensa.Width = 90;
        defensa.Height = 60;
        defensa.SizeMode = PictureBoxSizeMode.StretchImage;
        defensa.Image = SpaceInvaders.Properties.Resources.piedra1;

    }   
    
    public PictureBox getDefensa() {  
        return defensa;
    }

    public void destruir(int i) {
        this.vidas -= i;
        if (this.vidas == 0) {
            defensa.Dispose();
        } else {
            cambio();
        }

    }

    public void cambio() {
        switch (vidas) {
            case 1:
                defensa.Image = SpaceInvaders.Properties.Resources.piedra3;
            break;
            case 2:
                defensa.Image = SpaceInvaders.Properties.Resources.piedra2;
            break;
            case 3:
                defensa.Image = SpaceInvaders.Properties.Resources.piedra1;
            break;
        }
    }

    public int getVidas() {
        return vidas;
    }

}

