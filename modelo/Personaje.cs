using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceInvaders.vista;

public class Personaje {
        private Vista vista;
        private PictureBox personaje;
        private int vida;
        private int paso;
    public Personaje(Vista vista, int paso) {
        this.paso = paso;
        this.vista = vista;
        this.personaje = new PictureBox();
        this.vida = 3;
        personaje.Location = new System.Drawing.Point(500, 607);
        personaje.Width = 50;
        personaje.Height = 50;
        personaje.SizeMode = PictureBoxSizeMode.StretchImage;
        vista.panelJuego.Controls.Add(this.personaje);
        personaje.Image = SpaceInvaders.Properties.Resources.nave1;
        this.paso = paso;
    }

    public void moverIzq(){
        if (personaje.Location.X > 14){
                personaje.Left = personaje.Left - paso;
        }
            
            
    }
        
    public void moverDer(){
        if(personaje.Location.X < 1036){
                personaje.Left = personaje.Left + paso;
        }
            
    }

    public Boolean destruir(int i) {
        Boolean salida = false;
        vida--;
        if (vida == 0) {
            salida = true;
        } else {
            foreach(var clave in vista.disparosEnemigos) {
                clave.destruir();
            }
            vista.disparosEnemigos.Clear();
            vista.lblVidas.Text = "VIDAS:" + vida.ToString(); 
            personaje.Left = 500;
        }
        return salida;
    }

    public PictureBox getPersonaje() {
        return personaje;
    }

    public int getVida() {
        return vida;
    }

    public void setVida(int vida) {
        this.vida = vida;
    }

    public void setPaso(int paso) {
        this.paso = paso;
    }

    public int getPaso() {
        return paso;
    }


}


