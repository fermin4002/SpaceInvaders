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
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnClasificacion = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.fotoInicio = new System.Windows.Forms.PictureBox();
            this.fondoMenu = new System.Windows.Forms.PictureBox();
            this.panelVidasPunto = new System.Windows.Forms.Panel();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblVidas = new System.Windows.Forms.Label();
            this.iconoPersonaje = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondoMenu)).BeginInit();
            this.panelVidasPunto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoPersonaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRanking.SuspendLayout();
            this.panelGameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panelMenu.Controls.Add(this.pictureBox12);
            this.panelMenu.Controls.Add(this.pictureBox11);
            this.panelMenu.Controls.Add(this.pictureBox10);
            this.panelMenu.Controls.Add(this.pictureBox9);
            this.panelMenu.Controls.Add(this.pictureBox8);
            this.panelMenu.Controls.Add(this.pictureBox7);
            this.panelMenu.Controls.Add(this.pictureBox6);
            this.panelMenu.Controls.Add(this.pictureBox5);
            this.panelMenu.Controls.Add(this.pictureBox4);
            this.panelMenu.Controls.Add(this.pictureBox3);
            this.panelMenu.Controls.Add(this.btnClasificacion);
            this.panelMenu.Controls.Add(this.btnStart);
            this.panelMenu.Controls.Add(this.fotoInicio);
            this.panelMenu.Controls.Add(this.fondoMenu);
            this.panelMenu.Location = new System.Drawing.Point(8, 8);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1126, 768);
            this.panelMenu.TabIndex = 1;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = global::SpaceInvaders.Properties.Resources.back;
            this.pictureBox12.Image = global::SpaceInvaders.Properties.Resources.tiroEnemigo1;
            this.pictureBox12.Location = new System.Drawing.Point(955, 272);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(20, 70);
            this.pictureBox12.TabIndex = 13;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::SpaceInvaders.Properties.Resources.back;
            this.pictureBox11.Image = global::SpaceInvaders.Properties.Resources.tiro1;
            this.pictureBox11.Location = new System.Drawing.Point(955, 578);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(20, 70);
            this.pictureBox11.TabIndex = 12;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::SpaceInvaders.Properties.Resources.back;
            this.pictureBox10.Image = global::SpaceInvaders.Properties.Resources.nave31;
            this.pictureBox10.InitialImage = null;
            this.pictureBox10.Location = new System.Drawing.Point(915, 657);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 100);
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::SpaceInvaders.Properties.Resources.back;
            this.pictureBox9.Image = global::SpaceInvaders.Properties.Resources.enem21;
            this.pictureBox9.Location = new System.Drawing.Point(767, 330);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 100);
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::SpaceInvaders.Properties.Resources.back;
            this.pictureBox8.Image = global::SpaceInvaders.Properties.Resources.enem21;
            this.pictureBox8.Location = new System.Drawing.Point(249, 317);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 100);
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::SpaceInvaders.Properties.Resources.back;
            this.pictureBox7.Image = global::SpaceInvaders.Properties.Resources.enem21;
            this.pictureBox7.Location = new System.Drawing.Point(915, 166);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 100);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::SpaceInvaders.Properties.Resources.back;
            this.pictureBox6.Image = global::SpaceInvaders.Properties.Resources.enem21;
            this.pictureBox6.Location = new System.Drawing.Point(1012, 307);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 100);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::SpaceInvaders.Properties.Resources.back;
            this.pictureBox5.Image = global::SpaceInvaders.Properties.Resources.tiro1;
            this.pictureBox5.Location = new System.Drawing.Point(130, 449);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 70);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::SpaceInvaders.Properties.Resources.back;
            this.pictureBox4.Image = global::SpaceInvaders.Properties.Resources.nave31;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(92, 530);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::SpaceInvaders.Properties.Resources.back;
            this.pictureBox3.Image = global::SpaceInvaders.Properties.Resources.enem21;
            this.pictureBox3.Location = new System.Drawing.Point(92, 176);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnClasificacion
            // 
            this.btnClasificacion.Image = global::SpaceInvaders.Properties.Resources.btnRanking__1_;
            this.btnClasificacion.Location = new System.Drawing.Point(458, 481);
            this.btnClasificacion.Name = "btnClasificacion";
            this.btnClasificacion.Size = new System.Drawing.Size(200, 200);
            this.btnClasificacion.TabIndex = 2;
            this.btnClasificacion.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::SpaceInvaders.Properties.Resources.play_button;
            this.btnStart.Location = new System.Drawing.Point(400, 347);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(300, 70);
            this.btnStart.TabIndex = 1;
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // fotoInicio
            // 
            this.fotoInicio.BackgroundImage = global::SpaceInvaders.Properties.Resources.titulo;
            this.fotoInicio.ErrorImage = null;
            this.fotoInicio.InitialImage = null;
            this.fotoInicio.Location = new System.Drawing.Point(263, 20);
            this.fotoInicio.Name = "fotoInicio";
            this.fotoInicio.Size = new System.Drawing.Size(600, 267);
            this.fotoInicio.TabIndex = 0;
            this.fotoInicio.TabStop = false;
            // 
            // fondoMenu
            // 
            this.fondoMenu.BackgroundImage = global::SpaceInvaders.Properties.Resources.back1;
            this.fondoMenu.Location = new System.Drawing.Point(0, 0);
            this.fondoMenu.Name = "fondoMenu";
            this.fondoMenu.Size = new System.Drawing.Size(1126, 768);
            this.fondoMenu.TabIndex = 3;
            this.fondoMenu.TabStop = false;
            // 
            // panelVidasPunto
            // 
            this.panelVidasPunto.Controls.Add(this.lblPuntos);
            this.panelVidasPunto.Controls.Add(this.lblVidas);
            this.panelVidasPunto.Controls.Add(this.iconoPersonaje);
            this.panelVidasPunto.Controls.Add(this.pictureBox1);
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
            this.iconoPersonaje.BackgroundImage = global::SpaceInvaders.Properties.Resources.nave2bg;
            this.iconoPersonaje.Location = new System.Drawing.Point(14, 17);
            this.iconoPersonaje.Name = "iconoPersonaje";
            this.iconoPersonaje.Size = new System.Drawing.Size(70, 70);
            this.iconoPersonaje.TabIndex = 0;
            this.iconoPersonaje.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1100, 103);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.panelGameOver.Controls.Add(this.pictureBox2);
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
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SpaceInvaders.Properties.Resources.gameOver1__1_;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(75, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 209);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SpaceInvaders.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(1146, 788);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelVidasPunto);
            this.Controls.Add(this.panelGameOver);
            this.Controls.Add(this.panelRanking);
            this.Controls.Add(this.panelJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Vista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Invader";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondoMenu)).EndInit();
            this.panelVidasPunto.ResumeLayout(false);
            this.panelVidasPunto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoPersonaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRanking.ResumeLayout(false);
            this.panelRanking.PerformLayout();
            this.panelGameOver.ResumeLayout(false);
            this.panelGameOver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        public System.Windows.Forms.PictureBox fotoInicio;
        public System.Windows.Forms.Button btnClasificacion;
        public System.Windows.Forms.Button btnStart; 
        public System.Windows.Forms.Panel panelVidasPunto;
        public System.Windows.Forms.Label lblVidas;
        public System.Windows.Forms.PictureBox iconoPersonaje;
        public System.Windows.Forms.Label lblPuntos;
        public System.Windows.Forms.Panel panelRanking;
        public System.Windows.Forms.Label lblRanking;
        public System.Windows.Forms.Button btnSalir;
        public PictureBox fondoMenu;
        public PictureBox pictureBox1;
        public Panel panelGameOver;
        public System.Windows.Forms.TextBox txtNombre;
        public PictureBox pictureBox2;
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
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;

        //

    }
}