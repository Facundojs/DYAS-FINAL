using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OrganizadorBusiness usuarioBusiness = new OrganizadorBusiness();


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            string usuario = txtUsuario.Text;
            string contraseña = txtCotraseña.Text;

           

            try
            {
                var usuarioLogueado = usuarioBusiness.Login(usuario, contraseña);
                if (usuarioLogueado != null)
                {
                    // CREO una instancia del formulario Registro
                    FormHome hForm = new FormHome(usuarioLogueado);

                    // Muestro el formulario Registro
                    hForm.Show();

                    // Cierro el formulario Login
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Credenciales Incorrectas");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            // CREO una instancia del formulario Registro
            Registro registroForm = new Registro();

            // Muestro el formulario Registro
            registroForm.Show();

            // Cierro el formulario Login
            this.Hide();
        }
    }
}
