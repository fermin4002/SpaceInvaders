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
           // PrivateFontCollection pfc = new PrivateFontCollection();
            //pfc.AddFontFile(Path.Combine(Application.StartupPath, "Resources", "arcade.TTF"));
            //font = new Font(pfc.Families[0], 36, FontStyle.Regular);
            controlador = new Controlador(this);
        }

        
    }


}
