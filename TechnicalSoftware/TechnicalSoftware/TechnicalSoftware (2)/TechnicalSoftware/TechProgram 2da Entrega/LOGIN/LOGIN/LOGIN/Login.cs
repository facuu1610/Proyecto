using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LOGIN
{
    public partial class Login : Form
    {
        conexion conn = new conexion();
        

        public Login()
        {
            InitializeComponent();
        }

       
        
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO") {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "") {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA") {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }
        

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text =="") {
                txtPass.Text ="CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que deseas salir del programa?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsuario.Text !="" && txtPass.Text != "")
                {
                    conn.Abrir();
                    string consulta = "SELECT * FROM usuarios WHERE nombre ='" + txtUsuario.Text + "' AND password ='" + txtPass.Text + "'";
                    MySqlDataReader fila;
                    fila = conn.EjecutarDataReader(consulta);
                    if (fila.HasRows)
                    {
                        MessageBox.Show("Bienvenido " + txtUsuario.Text);
                        Menu CambioF = new Menu();
                        CambioF.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado, verifique", "ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese usuario y contraseña");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conexión");
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

