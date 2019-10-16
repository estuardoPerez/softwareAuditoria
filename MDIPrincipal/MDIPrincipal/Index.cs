/* AUTOR: JULIO SICAJA */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejemploVentana;

namespace MDIPrincipal
{
    public partial class Index : Form
    {
        private void priChildMDI(Form fmr)
        {
           if (Application.OpenForms[fmr.Name] != null)
            {
                Application.OpenForms[fmr.Name].Activate();
            }
            else
            {
                fmr.MdiParent = this;
                fmr.StartPosition = FormStartPosition.CenterScreen;
                fmr.Show();
            }
        }
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            this.Location = new Point(0, 0);  //sobra si tienes la posición en el diseño
            Form fmr_logo = new logo();
            fmr_logo.MdiParent = this;
            fmr_logo.StartPosition = FormStartPosition.CenterScreen;
            fmr_logo.Enabled = false;
            fmr_logo.Show();

            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;                
                }
                catch (InvalidCastException exc)
                {

                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priChildMDI(new Form1());
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
