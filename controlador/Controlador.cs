using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceInvaders.modelo;
using SpaceInvaders.vista;

namespace SpaceInvaders.controlador
{
    internal class Controlador 
    {
       
        private Vista vista;
    
        private Button boton1, boton2;
        public Controlador(Vista vista)
        {
            this.vista = vista;



            
        }

        //Inicio app
        public void button_click(object sender, EventArgs e)
        {
            Button botonPresionado = sender as Button;
            
            if (botonPresionado != null)
            {
                switch (botonPresionado.Name)
                {
                    case "button1":
                       
                        break;
                    case "button2":
                       
                        break;
                }
            }
        }
    }
}
