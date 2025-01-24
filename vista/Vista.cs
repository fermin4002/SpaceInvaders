using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SpaceInvaders.controlador;

namespace SpaceInvaders.vista
{
    public partial class Vista : Form
    {
        private Controlador controlador;
        public Vista()
        {
            InitializeComponent();
            
            controlador = new Controlador(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
