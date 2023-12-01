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
        private InvitadoBusiness invitadoBusiness = new InvitadoBusiness();
        private FacturaBusiness facturaBusiness = new FacturaBusiness();
        private ServicioBusiness servicioBusiness = new ServicioBusiness();

        public FormHome(OrganizadorEntity o)
        {
            InitializeComponent();
            organizador = o;
            eventoBusiness = new EventoBusiness();
            CargarTablaEventos();
            CargarCombosEventos();
            CargarServiciosCombo();
        }
        private OrganizadorEntity organizador;


        private void CargarTablaEventos()
        {
            dataGridEventos.DataSource = null;
            dataGridEventos.DataSource = eventoBusiness.Listar(organizador.CodigoOrganizador);
        }

        public void CargarCombosEventos()
        {
            comboEventosEliminar.DataSource = null;
            comboEventosContr.DataSource = null;
            comboEventosInvi.DataSource = null;
            comboEventosInvitados.DataSource = null;
            comboEventosPagar.DataSource = null;

            var eventosDb = eventoBusiness.Listar(organizador.CodigoOrganizador);

            comboEventosEliminar.DataSource = eventosDb;
            comboEventosContr.DataSource = eventosDb;
            comboEventosInvi.DataSource = eventosDb;
            comboEventosInvitados.DataSource = eventosDb;
            comboEventosPagar.DataSource = eventosDb;

            comboEventosEliminar.ValueMember = "CodigoEvento";
            comboEventosContr.ValueMember = "CodigoEvento";
            comboEventosInvi.ValueMember = "CodigoEvento";
            comboEventosInvitados.ValueMember = "CodigoEvento";
            comboEventosPagar.ValueMember = "CodigoEvento";

            comboEventosEliminar.DisplayMember = "Nombre";
            comboEventosContr.DisplayMember = "Nombre";
            comboEventosInvi.DisplayMember = "Nombre";
            comboEventosInvitados.DisplayMember = "Nombre";
            comboEventosPagar.DisplayMember = "Nombre";

        }

        public void CargarServiciosCombo()
        {
            comboServicios.DataSource = null;
            comboServicios.DataSource = servicioBusiness.ListarServicios();

            comboServicios.ValueMember = "CodigoServicio";
            comboServicios.DisplayMember = "NombreServicio";
        }
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
            try
            {
                eventoBusiness.BorrarEvento(Convert.ToInt32(comboEventosEliminar.SelectedValue));
                CargarTablaEventos();
                CargarCombosEventos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnContratarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioContratadoEntity serv = new ServicioContratadoEntity();
                

                serv.NombreServicio = (comboServicios.SelectedItem as ServicioEntity).NombreServicio;
                serv.Descripcion = (comboServicios.SelectedItem as ServicioEntity).Descripcion;
                serv.CodigoServicio = Convert.ToInt32(comboServicios.SelectedValue);
                serv.Cantidad = Convert.ToInt32(txtCantidadServ.Text);
                serv.Precio = (comboServicios.SelectedItem as ServicioEntity).Precio;
                serv.Subtotal = serv.Cantidad * serv.Precio;

                eventoBusiness.AñadirServicioContratado(Convert.ToInt32(comboEventosContr.SelectedValue), serv);
                CargarCombosEventos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPagarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                 eventoBusiness.PagarEvento(Convert.ToInt32(comboEventosPagar.SelectedValue));
                 
                 CargarCombosEventos();
                 CargarTablaEventos();
                 MessageBox.Show("Ha pagado su Evento correctamente!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAgregarInvitado_Click(object sender, EventArgs e)
        {
            try
            {
                InvitadoEntity invi = new InvitadoEntity();
                invi.CodigoEvento = Convert.ToInt32(comboEventosInvi.SelectedValue);
                invi.Nombre = txtNombreInvi.Text;
                invi.Apellido = txtApellidoInvi.Text;
                invi.Email = txtEmailInvi.Text;

                invitadoBusiness.Crear(invi);

                dataListaInvitados.DataSource = null;
                var invitados = invitadoBusiness.Listar(Convert.ToInt32(comboEventosInvitados.SelectedValue));
                dataListaInvitados.DataSource = invitados;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerInvitados_Click(object sender, EventArgs e)
        {
            try
            {
                dataListaInvitados.DataSource = null;
                var invitados = invitadoBusiness.Listar(Convert.ToInt32(comboEventosInvitados.SelectedValue));
                dataListaInvitados.DataSource = invitados;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
         //CargarTablaEventos();

        }
    }
}
