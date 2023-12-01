using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace UI
{
    public partial class FormHome : Form
    {
        private EventoBusiness eventoBusiness = new EventoBusiness();
       

        public FormHome(OrganizadorEntity o)
        {
            InitializeComponent();
            organizador = o;
            eventoBusiness = new EventoBusiness();
        }
        private OrganizadorEntity organizador;

       /* private void CargarTablaEventos()
        {
            dataGridEventos.DataSource = null;
            dataGridEventos.DataSource = eventoBusiness.listarEventos();
        }*/

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

      
        private void btnGuardarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                eventoBusiness.CrearEvento(new EventoEntity
                {
                    CodigoOrganizador = organizador.CodigoOrganizador,
                    Nombre = txtNomEvento.Text,
                    Fecha = datePicker.Value,
                    Lugar = txtUbicaEve.Text,
                    Invitados = new List<InvitadoEntity>(),
                    ServiciosContratados = new List<ServicioContratadoEntity>()
                });

                MessageBox.Show("Evento creado con éxito!");

                txtNomEvento.Clear();
                txtUbicaEve.Clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnEliminarEvento_Click(object sender, EventArgs e)
        {

        }

        private void btnContratarServicio_Click(object sender, EventArgs e)
        {

        }

        private void btnPagarEvento_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarInvitado_Click(object sender, EventArgs e)
        {

        }

        private void btnVerInvitados_Click(object sender, EventArgs e)
        {

        }
        private void FormHome_Load(object sender, EventArgs e)
        {
         // CargarTablaEventos();

        }
    }
}
