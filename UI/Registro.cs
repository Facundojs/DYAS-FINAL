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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            // CREO una instancia del formulario Registro
            Login Log = new Login();

            // Muestro el formulario Registro
            Log.Show();

            // Cierro el formulario Login
            this.Hide();
        }
    }
}
