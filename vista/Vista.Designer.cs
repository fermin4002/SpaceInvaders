using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace SpaceInvaders.vista
{
    partial class Vista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista));
            this.panelJuego = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnClasificacion = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelVidasPunto = new System.Windows.Forms.Panel();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblVidas = new System.Windows.Forms.Label();
            this.iconoPersonaje = new System.Windows.Forms.PictureBox();
            this.panelRanking = new System.Windows.Forms.Panel();
            this.rankingPuntos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRanking = new System.Windows.Forms.Label();
            this.Indice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Puntuacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelGameOver = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuExit = new System.Windows.Forms.Button();
            this.lblPuntosGameOver = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.fotoGameOver = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelVidasPunto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoPersonaje)).BeginInit();
            this.panelRanking.SuspendLayout();
            this.panelGameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoGameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // panelJuego
            // 
            this.panelJuego.Location = new System.Drawing.Point(23, 114);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(1100, 660);
            this.panelJuego.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.BackgroundImage = global::SpaceInvaders.Properties.Resources.fondo__1_3;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMenu.Controls.Add(this.pictureBox4);
            this.panelMenu.Controls.Add(this.btnClasificacion);
            this.panelMenu.Controls.Add(this.btnStart);
            this.panelMenu.Location = new System.Drawing.Point(8, 8);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1126, 768);
            this.panelMenu.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::SpaceInvaders.Properties.Resources.back;
            this.pictureBox4.Image = global::SpaceInvaders.Properties.Resources.teclas1;
            this.pictureBox4.Location = new System.Drawing.Point(745, 511);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 150);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // btnClasificacion
            // 
            this.btnClasificacion.Image = global::SpaceInvaders.Properties.Resources.btnRanking__1_;
            this.btnClasificacion.Location = new System.Drawing.Point(486, 477);
            this.btnClasificacion.Name = "btnClasificacion";
            this.btnClasificacion.Size = new System.Drawing.Size(200, 200);
            this.btnClasificacion.TabIndex = 2;
            this.btnClasificacion.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::SpaceInvaders.Properties.Resources.play_button;
            this.btnStart.Location = new System.Drawing.Point(439, 349);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(300, 70);
            this.btnStart.TabIndex = 1;
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // panelVidasPunto
            // 
            this.panelVidasPunto.Controls.Add(this.lblPuntos);
            this.panelVidasPunto.Controls.Add(this.lblVidas);
            this.panelVidasPunto.Controls.Add(this.iconoPersonaje);
            this.panelVidasPunto.Location = new System.Drawing.Point(23, 11);
            this.panelVidasPunto.Name = "panelVidasPunto";
            this.panelVidasPunto.Size = new System.Drawing.Size(1100, 103);
            this.panelVidasPunto.TabIndex = 2;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPuntos.Location = new System.Drawing.Point(400, 33);
            this.lblPuntos.MinimumSize = new System.Drawing.Size(300, 0);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(300, 55);
            this.lblPuntos.TabIndex = 2;
            this.lblPuntos.Text = "0";
            this.lblPuntos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVidas.Location = new System.Drawing.Point(90, 32);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(191, 55);
            this.lblVidas.TabIndex = 1;
            this.lblVidas.Text = "Vidas:3";
            // 
            // iconoPersonaje
            // 
            this.iconoPersonaje.Image = global::SpaceInvaders.Properties.Resources.nave2bg;
            this.iconoPersonaje.Location = new System.Drawing.Point(14, 17);
            this.iconoPersonaje.Name = "iconoPersonaje";
            this.iconoPersonaje.Size = new System.Drawing.Size(70, 70);
            this.iconoPersonaje.TabIndex = 0;
            this.iconoPersonaje.TabStop = false;
            // 
            // panelRanking
            // 
            this.panelRanking.BackgroundImage = global::SpaceInvaders.Properties.Resources.space;
            this.panelRanking.Controls.Add(this.rankingPuntos);
            this.panelRanking.Controls.Add(this.btnSalir);
            this.panelRanking.Controls.Add(this.lblRanking);
            this.panelRanking.Location = new System.Drawing.Point(100, 10);
            this.panelRanking.Name = "panelRanking";
            this.panelRanking.Size = new System.Drawing.Size(950, 758);
            this.panelRanking.TabIndex = 3;
            // 
            // rankingPuntos
            // 
            this.rankingPuntos.BackgroundImage = global::SpaceInvaders.Properties.Resources.sas__1_;
            this.rankingPuntos.BackgroundImageTiled = true;
            this.rankingPuntos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.rankingPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankingPuntos.ForeColor = System.Drawing.SystemColors.Info;
            this.rankingPuntos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.rankingPuntos.HideSelection = false;
            this.rankingPuntos.Location = new System.Drawing.Point(175, 129);
            this.rankingPuntos.Name = "rankingPuntos";
            this.rankingPuntos.Size = new System.Drawing.Size(600, 550);
            this.rankingPuntos.TabIndex = 2;
            this.rankingPuntos.UseCompatibleStateImageBehavior = false;
            this.rankingPuntos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 275;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 275;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::SpaceInvaders.Properties.Resources.salir__2_;
            this.btnSalir.Location = new System.Drawing.Point(877, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 70);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.BackColor = System.Drawing.Color.Black;
            this.lblRanking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRanking.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRanking.Location = new System.Drawing.Point(325, 16);
            this.lblRanking.MinimumSize = new System.Drawing.Size(300, 0);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(333, 75);
            this.lblRanking.TabIndex = 0;
            this.lblRanking.Text = "RANKING";
            this.lblRanking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nombre
            // 
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Puntuacion
            // 
            this.Puntuacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelGameOver
            // 
            this.panelGameOver.BackgroundImage = global::SpaceInvaders.Properties.Resources.sas__1_;
            this.panelGameOver.Controls.Add(this.label1);
            this.panelGameOver.Controls.Add(this.btnMenuExit);
            this.panelGameOver.Controls.Add(this.lblPuntosGameOver);
            this.panelGameOver.Controls.Add(this.txtNombre);
            this.panelGameOver.Controls.Add(this.fotoGameOver);
            this.panelGameOver.Location = new System.Drawing.Point(233, 156);
            this.panelGameOver.Name = "panelGameOver";
            this.panelGameOver.Size = new System.Drawing.Size(650, 500);
            this.panelGameOver.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(74, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del jugador:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnMenuExit
            // 
            this.btnMenuExit.Image = global::SpaceInvaders.Properties.Resources.inicio1;
            this.btnMenuExit.Location = new System.Drawing.Point(175, 382);
            this.btnMenuExit.Name = "btnMenuExit";
            this.btnMenuExit.Size = new System.Drawing.Size(300, 80);
            this.btnMenuExit.TabIndex = 3;
            this.btnMenuExit.UseVisualStyleBackColor = true;
            // 
            // lblPuntosGameOver
            // 
            this.lblPuntosGameOver.AutoSize = true;
            this.lblPuntosGameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPuntosGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosGameOver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPuntosGameOver.Location = new System.Drawing.Point(74, 241);
            this.lblPuntosGameOver.MinimumSize = new System.Drawing.Size(499, 40);
            this.lblPuntosGameOver.Name = "lblPuntosGameOver";
            this.lblPuntosGameOver.Size = new System.Drawing.Size(499, 41);
            this.lblPuntosGameOver.TabIndex = 2;
            this.lblPuntosGameOver.Text = "PUNTOS";
            this.lblPuntosGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(74, 329);
            this.txtNombre.MaximumSize = new System.Drawing.Size(499, 40);
            this.txtNombre.MinimumSize = new System.Drawing.Size(499, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(499, 47);
            this.txtNombre.TabIndex = 1;
            // 
            // fotoGameOver
            // 
            this.fotoGameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fotoGameOver.Image = global::SpaceInvaders.Properties.Resources.gameOver1__1_;
            this.fotoGameOver.Location = new System.Drawing.Point(75, 18);
            this.fotoGameOver.Name = "fotoGameOver";
            this.fotoGameOver.Size = new System.Drawing.Size(500, 209);
            this.fotoGameOver.TabIndex = 0;
            this.fotoGameOver.TabStop = false;
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SpaceInvaders.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(1146, 788);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelRanking);
            this.Controls.Add(this.panelGameOver);
            this.Controls.Add(this.panelVidasPunto);
            this.Controls.Add(this.panelJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Vista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Invader";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelVidasPunto.ResumeLayout(false);
            this.panelVidasPunto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoPersonaje)).EndInit();
            this.panelRanking.ResumeLayout(false);
            this.panelRanking.PerformLayout();
            this.panelGameOver.ResumeLayout(false);
            this.panelGameOver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoGameOver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //Elementos del juego
        public List<Disparo> disparos = new List<Disparo>();
        public List<DisparoEnemigo> disparosEnemigos = new List<DisparoEnemigo>();
        public List<Enemigo> enemigos = new List<Enemigo>();
        public List<Defensa> defensas = new List<Defensa>();
        public Personaje personaje;
        //
        public System.Windows.Forms.Panel panelJuego;
        public System.Windows.Forms.Panel panelMenu;
        public System.Windows.Forms.Button btnClasificacion;
        public System.Windows.Forms.Button btnStart; 
        public System.Windows.Forms.Panel panelVidasPunto;
        public System.Windows.Forms.Label lblVidas;
        public System.Windows.Forms.PictureBox iconoPersonaje;
        public System.Windows.Forms.Label lblPuntos;
        public System.Windows.Forms.Panel panelRanking;
        public System.Windows.Forms.Label lblRanking;
        public System.Windows.Forms.Button btnSalir;
        public Panel panelGameOver;
        public System.Windows.Forms.TextBox txtNombre;
        public PictureBox fotoGameOver;
        public Label lblPuntosGameOver;
        public System.Windows.Forms.Button btnMenuExit;
        public ColumnHeader Indice;
        public ColumnHeader Nombre;
        public ColumnHeader Puntuacion;
        public System.Windows.Forms.ListView rankingPuntos;
        public ColumnHeader columnHeader2;
        public ColumnHeader columnHeader3;
        public ColumnHeader columnHeader1;
        private Label label1;
        private PictureBox pictureBox4;

        //

    }
}