using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SpaceInvaders.vista
{
    public partial class Vista : Form
    {
        
        private Controlador controlador;
        public Vista()
        {
            InitializeComponent();
           
            controlador = new Controlador(this);
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
        }

        private void OnApplicationExit(object sender, EventArgs e) {
           
            controlador.crearJson();
        }

       
    }


}
