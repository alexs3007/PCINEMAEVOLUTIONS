﻿namespace CapaPresentacion.Formularios
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlcerrar = new System.Windows.Forms.Panel();
            this.pnlCambioUsuario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlFactura = new System.Windows.Forms.Panel();
            this.pnlCarteleraS = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.pnlCartelera = new System.Windows.Forms.Panel();
=======
            this.pnlFactura = new System.Windows.Forms.Panel();
            this.pnlPelicula = new System.Windows.Forms.Panel();
            this.pnlTecnologia = new System.Windows.Forms.Panel();
>>>>>>> 0d7d7f757ef84c148b777e7235489a5f6d83b0c9
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 719);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1362, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // pnlcerrar
            // 
            this.pnlcerrar.BackColor = System.Drawing.Color.Transparent;
            this.pnlcerrar.BackgroundImage = global::CapaPresentacion.Properties.Resources.X;
            this.pnlcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlcerrar.Location = new System.Drawing.Point(1320, 0);
            this.pnlcerrar.Name = "pnlcerrar";
            this.pnlcerrar.Size = new System.Drawing.Size(42, 42);
            this.pnlcerrar.TabIndex = 4;
            this.pnlcerrar.Click += new System.EventHandler(this.pnlcerrar_Click);
            // 
            // pnlCambioUsuario
            // 
            this.pnlCambioUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pnlCambioUsuario.BackgroundImage = global::CapaPresentacion.Properties.Resources.logout_icon_150x150;
            this.pnlCambioUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCambioUsuario.Location = new System.Drawing.Point(1272, 0);
            this.pnlCambioUsuario.Name = "pnlCambioUsuario";
            this.pnlCambioUsuario.Size = new System.Drawing.Size(42, 42);
            this.pnlCambioUsuario.TabIndex = 5;
            this.pnlCambioUsuario.Click += new System.EventHandler(this.pnlCambioUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = global::CapaPresentacion.Properties.Resources.bordesuperior;
            this.panel1.Controls.Add(this.pnlFactura);
            this.panel1.Controls.Add(this.pnlCarteleraS);
            this.panel1.Controls.Add(this.pnlcerrar);
            this.panel1.Controls.Add(this.pnlCambioUsuario);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 58);
            this.panel1.TabIndex = 7;
            // 
            // pnlFactura
            // 
            this.pnlFactura.BackgroundImage = global::CapaPresentacion.Properties.Resources.factura;
            this.pnlFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFactura.Location = new System.Drawing.Point(128, 5);
            this.pnlFactura.Name = "pnlFactura";
            this.pnlFactura.Size = new System.Drawing.Size(50, 50);
            this.pnlFactura.TabIndex = 10;
            this.pnlFactura.Click += new System.EventHandler(this.pnlFactura_Click);
            // 
            // pnlCarteleraS
            // 
            this.pnlCarteleraS.BackColor = System.Drawing.Color.Transparent;
            this.pnlCarteleraS.BackgroundImage = global::CapaPresentacion.Properties.Resources.carterleracirculo;
            this.pnlCarteleraS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
<<<<<<< HEAD
            this.pnlCarteleraS.Location = new System.Drawing.Point(71, 5);
=======
            this.pnlCarteleraS.Location = new System.Drawing.Point(26, 51);
>>>>>>> 0d7d7f757ef84c148b777e7235489a5f6d83b0c9
            this.pnlCarteleraS.Name = "pnlCarteleraS";
            this.pnlCarteleraS.Size = new System.Drawing.Size(50, 50);
            this.pnlCarteleraS.TabIndex = 9;
            this.pnlCarteleraS.Click += new System.EventHandler(this.pnlCarteleraS_Click);
            // 
<<<<<<< HEAD
            // pnlCartelera
            // 
            this.pnlCartelera.Location = new System.Drawing.Point(12, 165);
            this.pnlCartelera.Name = "pnlCartelera";
            this.pnlCartelera.Size = new System.Drawing.Size(0, 0);
            this.pnlCartelera.TabIndex = 0;
=======
            // pnlFactura
            // 
            this.pnlFactura.BackColor = System.Drawing.Color.Transparent;
            this.pnlFactura.BackgroundImage = global::CapaPresentacion.Properties.Resources.factura;
            this.pnlFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFactura.Location = new System.Drawing.Point(132, 51);
            this.pnlFactura.Name = "pnlFactura";
            this.pnlFactura.Size = new System.Drawing.Size(100, 100);
            this.pnlFactura.TabIndex = 13;
            this.pnlFactura.Click += new System.EventHandler(this.pnlFactura_Click);
            // 
            // pnlPelicula
            // 
            this.pnlPelicula.BackColor = System.Drawing.Color.Transparent;
            this.pnlPelicula.BackgroundImage = global::CapaPresentacion.Properties.Resources.pelicula;
            this.pnlPelicula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPelicula.Location = new System.Drawing.Point(238, 51);
            this.pnlPelicula.Name = "pnlPelicula";
            this.pnlPelicula.Size = new System.Drawing.Size(100, 100);
            this.pnlPelicula.TabIndex = 15;
            this.pnlPelicula.Click += new System.EventHandler(this.pnlPelicula_Click);
            // 
            // pnlTecnologia
            // 
            this.pnlTecnologia.BackgroundImage = global::CapaPresentacion.Properties.Resources.tecnologia;
            this.pnlTecnologia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTecnologia.Location = new System.Drawing.Point(344, 51);
            this.pnlTecnologia.Name = "pnlTecnologia";
            this.pnlTecnologia.Size = new System.Drawing.Size(100, 100);
            this.pnlTecnologia.TabIndex = 17;
            this.pnlTecnologia.Click += new System.EventHandler(this.pnlTecnologia_Click);
>>>>>>> 0d7d7f757ef84c148b777e7235489a5f6d83b0c9
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
<<<<<<< HEAD
            this.Controls.Add(this.pnlCartelera);
=======
            this.Controls.Add(this.pnlTecnologia);
            this.Controls.Add(this.pnlPelicula);
            this.Controls.Add(this.pnlFactura);
            this.Controls.Add(this.pnlCarteleraS);
>>>>>>> 0d7d7f757ef84c148b777e7235489a5f6d83b0c9
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Text = "Cinema Evolution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pnlcerrar;
        private System.Windows.Forms.Panel pnlCambioUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCartelera;
        private System.Windows.Forms.Panel pnlCarteleraS;
        private System.Windows.Forms.Panel pnlFactura;
<<<<<<< HEAD
=======
        private System.Windows.Forms.Panel pnlPelicula;
        private System.Windows.Forms.Panel pnlTecnologia;
>>>>>>> 0d7d7f757ef84c148b777e7235489a5f6d83b0c9
    }
}



