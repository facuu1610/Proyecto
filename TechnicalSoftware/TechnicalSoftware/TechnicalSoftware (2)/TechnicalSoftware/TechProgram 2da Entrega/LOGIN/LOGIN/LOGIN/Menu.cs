using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LOGIN
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que deseas salir del programa?","Alerta", MessageBoxButtons.YesNo)==DialogResult.Yes)
           {
                Application.Exit();
            }
        }
        int LX, LY;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1080, 615);
            this.Location = new Point(LX, LY);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraDeTITULO_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.btnSalir.Controls.Count > 0)
                this.btnSalir.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.btnSalir.Controls.Add(fh);
            this.btnSalir.Tag = fh;
            fh.Show();
        }

        private void btnSalir_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Socios());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new inicio());
        }

        private void btnCuotas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Cuotas());
        }

        private void BarraVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Docentes());
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Cursos());
        }

        private void BarraDeTITULO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login CambioF = new Login();
            CambioF.Show();
            this.Visible = false;
            
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
