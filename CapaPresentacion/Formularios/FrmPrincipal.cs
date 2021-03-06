﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pnlcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlCambioUsuario_Click(object sender, EventArgs e)
        {
            
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        //private void pnlCartelera_MouseHover(object sender, EventArgs e)
        //{
        //    pnlCartelera.BackgroundImage = CapaPresentacion.Properties.Resources.cartelera1;
        //}

        //private void pnlCartelera_MouseLeave(object sender, EventArgs e)
        //{
        //    pnlCartelera.BackgroundImage = CapaPresentacion.Properties.Resources.cartelera;
        //}

        //private void pnlCartelera_Click(object sender, EventArgs e)
        //{
        //    FrmCartelera frm = new FrmCartelera();
        //    frm.Show();
        //}

        private void pnlCartelera_MouseClick(object sender, MouseEventArgs e)
        {
            FrmCartelera frm = new FrmCartelera();
            frm.Show();
        }

        private void pnlCarteleraS_Click(object sender, EventArgs e)
        {
            FrmCartelera frm = new FrmCartelera();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new Point(200, 200);

        }

        private void pnlFactura_Click(object sender, EventArgs e)
        {
            FrmFactura frm = new FrmFactura();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new Point(320, 180);
        }

        private void pnlFactura_Click(object sender, EventArgs e)
        {
            FrmFactura frm = new FrmFactura();
            frm.Show();
            frm.Location = new Point(330, 180);
        }

        private void pnlPelicula_Click(object sender, EventArgs e)
        {
            FrmPelicula frm = new FrmPelicula();
            frm.Show();
            frm.Location = new Point(120, 130);
        }

        private void pnlTecnologia_Click(object sender, EventArgs e)
        {
            FrmPelicula_Tecnologia frm = new FrmPelicula_Tecnologia();
            frm.Show();
            frm.Location = new Point(120, 130);
        }
    }
}
