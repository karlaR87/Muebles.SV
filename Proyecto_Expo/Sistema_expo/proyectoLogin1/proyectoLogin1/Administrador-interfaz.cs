using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoLogin1
{
    public partial class Administrador_interfaz : Form
    {
        public Administrador_interfaz()
        {
            InitializeComponent();
        }

        private void Administrador_interfaz_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int m, mx, my;

        private void pTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void pTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void btnTiempo_Click(object sender, EventArgs e)
        {

        }

        private void pMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {

        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {

        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pTitulo_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }
        public void AbrirFormHija(object formHija)
        {
            if (this.pContenedor.Controls.Count > 0)
            {
                this.pContenedor.Controls.RemoveAt(0);
                Form fh = formHija as Form;
                //fh.TopLevel1;

            }
        }
    }
}
