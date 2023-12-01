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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            string usuario = txtUsuario.Text;
            string contraseña = txtCotraseña.Text;

            // VERIFICO que el usuario no esté vacío y tenga al menos 5 caracteres

            if (string.IsNullOrEmpty(usuario) || usuario.Length < 5)
            {
                MessageBox.Show("El nombre de usuario debe tener al menos 5 caracteres.");
                return;
            }
            else
            {
                // VERIFICO que la contraseña no esté vacía, tenga al menos 8 caracteres, una mayúscula y un número

                if (string.IsNullOrEmpty(contraseña) || contraseña.Length <= 8)
                {
                    MessageBox.Show("La contraseña debe tener al menos 8 caracteres");
                    return;
                }
                else
                {
                    // CREO una instancia del formulario Registro
                    FormHome hForm = new FormHome();

                    // Muestro el formulario Registro
                    hForm.Show();

                    // Cierro el formulario Login
                     this.Hide();
                }

            
            }


            // COMPARAR en la base de datos DbGestionEventos si el usuario existe y si coincide la contraseña

            /* using (var context = new DbGestionEventosEntities())  //  Creo el contexto de la base de datos (ver que el nombre es DbGestionEventosEntities o cambiarlo)
             {
                 try
                 {
                     var user = context.Usuarios.SingleOrDefault(u => u.Usuario == usuario);
                     if (user == null)
                     {
                         MessageBox.Show("El usuario no existe.");
                     }
                     else if (user.Contraseña != contraseña)
                     {
                         MessageBox.Show("La contraseña no coincide.");
                     }
                     else
                     {
                         MessageBox.Show("Inicio de sesión exitoso, Bienvenido!");

                         this.Hide();  // Cierro el formulario "Login"

                         // Abrir el formulario "Eventos"
                         Eventos eventosForm = new Eventos();
                         eventosForm.Show();
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Ocurrió un error al intentar acceder a la base de datos: " + ex.Message);
                 }
             }*/
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
