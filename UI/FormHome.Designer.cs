namespace UI
{
    partial class FormHome 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.label10 = new System.Windows.Forms.Label();
            this.comboEventosContr = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboServicios = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCantidadServ = new System.Windows.Forms.TextBox();
            this.btnContratarServicio = new System.Windows.Forms.Button();
            this.comboEventosInvi = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNombreInvi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtApellidoInvi = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEmailInvi = new System.Windows.Forms.TextBox();
            this.dataGridFacturas = new System.Windows.Forms.DataGridView();
            this.btnAgregarInvitado = new System.Windows.Forms.Button();
            this.comboEventosPagar = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnPagarEvento = new System.Windows.Forms.Button();
            this.comboEventosInvitados = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dataListaInvitados = new System.Windows.Forms.DataGridView();
            this.txtNomEvento = new System.Windows.Forms.TextBox();
            this.btnGuardarEvento = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridEventos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUbicaEve = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEventosEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminarEvento = new System.Windows.Forms.Button();
            this.btnVerInvitados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaInvitados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Gotham", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(98, 427);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Seleccione Evento:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // comboEventosContr
            // 
            this.comboEventosContr.FormattingEnabled = true;
            this.comboEventosContr.Location = new System.Drawing.Point(94, 452);
            this.comboEventosContr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboEventosContr.Name = "comboEventosContr";
            this.comboEventosContr.Size = new System.Drawing.Size(236, 28);
            this.comboEventosContr.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Font = new System.Drawing.Font("Gotham", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(95, 491);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "Seleccione Servicio:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // comboServicios
            // 
            this.comboServicios.FormattingEnabled = true;
            this.comboServicios.Location = new System.Drawing.Point(94, 515);
            this.comboServicios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboServicios.Name = "comboServicios";
            this.comboServicios.Size = new System.Drawing.Size(236, 28);
            this.comboServicios.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Font = new System.Drawing.Font("Gotham", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(94, 556);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 19);
            this.label13.TabIndex = 20;
            this.label13.Text = "Cantidad:";
            // 
            // txtCantidadServ
            // 
            this.txtCantidadServ.Location = new System.Drawing.Point(94, 581);
            this.txtCantidadServ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadServ.Name = "txtCantidadServ";
            this.txtCantidadServ.Size = new System.Drawing.Size(127, 26);
            this.txtCantidadServ.TabIndex = 21;
            // 
            // btnContratarServicio
            // 
            this.btnContratarServicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContratarServicio.Font = new System.Drawing.Font("GothamMedium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContratarServicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContratarServicio.Location = new System.Drawing.Point(117, 632);
            this.btnContratarServicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContratarServicio.Name = "btnContratarServicio";
            this.btnContratarServicio.Size = new System.Drawing.Size(212, 43);
            this.btnContratarServicio.TabIndex = 22;
            this.btnContratarServicio.Text = "Contratar Servicio";
            this.btnContratarServicio.UseVisualStyleBackColor = false;
            // 
            // comboEventosInvi
            // 
            this.comboEventosInvi.FormattingEnabled = true;
            this.comboEventosInvi.Location = new System.Drawing.Point(976, 139);
            this.comboEventosInvi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboEventosInvi.Name = "comboEventosInvi";
            this.comboEventosInvi.Size = new System.Drawing.Size(262, 28);
            this.comboEventosInvi.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Font = new System.Drawing.Font("Gotham", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(977, 115);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 19);
            this.label15.TabIndex = 24;
            this.label15.Text = "Seleccione Evento:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Font = new System.Drawing.Font("Gotham", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label16.Location = new System.Drawing.Point(975, 176);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 19);
            this.label16.TabIndex = 26;
            this.label16.Text = "Ingrese el Nombre:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtNombreInvi
            // 
            this.txtNombreInvi.Location = new System.Drawing.Point(976, 201);
            this.txtNombreInvi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreInvi.Name = "txtNombreInvi";
            this.txtNombreInvi.Size = new System.Drawing.Size(262, 26);
            this.txtNombreInvi.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Font = new System.Drawing.Font("Gotham", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label17.Location = new System.Drawing.Point(976, 237);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 19);
            this.label17.TabIndex = 28;
            this.label17.Text = "Ingrese el Apellido:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtApellidoInvi
            // 
            this.txtApellidoInvi.Location = new System.Drawing.Point(976, 262);
            this.txtApellidoInvi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellidoInvi.Name = "txtApellidoInvi";
            this.txtApellidoInvi.Size = new System.Drawing.Size(262, 26);
            this.txtApellidoInvi.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Font = new System.Drawing.Font("Gotham", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label18.Location = new System.Drawing.Point(979, 296);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 19);
            this.label18.TabIndex = 30;
            this.label18.Text = "Ingrese el Email:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txtEmailInvi
            // 
            this.txtEmailInvi.Location = new System.Drawing.Point(976, 321);
            this.txtEmailInvi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmailInvi.Name = "txtEmailInvi";
            this.txtEmailInvi.Size = new System.Drawing.Size(262, 26);
            this.txtEmailInvi.TabIndex = 31;
            // 
            // dataGridFacturas
            // 
            this.dataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacturas.Location = new System.Drawing.Point(416, 491);
            this.dataGridFacturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridFacturas.Name = "dataGridFacturas";
            this.dataGridFacturas.RowHeadersWidth = 62;
            this.dataGridFacturas.Size = new System.Drawing.Size(473, 128);
            this.dataGridFacturas.TabIndex = 32;
            // 
            // btnAgregarInvitado
            // 
            this.btnAgregarInvitado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarInvitado.Font = new System.Drawing.Font("GothamMedium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInvitado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarInvitado.Location = new System.Drawing.Point(1050, 355);
            this.btnAgregarInvitado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarInvitado.Name = "btnAgregarInvitado";
            this.btnAgregarInvitado.Size = new System.Drawing.Size(188, 43);
            this.btnAgregarInvitado.TabIndex = 33;
            this.btnAgregarInvitado.Text = "Agregar Invitado";
            this.btnAgregarInvitado.UseVisualStyleBackColor = false;
            // 
            // comboEventosPagar
            // 
            this.comboEventosPagar.FormattingEnabled = true;
            this.comboEventosPagar.Location = new System.Drawing.Point(415, 450);
            this.comboEventosPagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboEventosPagar.Name = "comboEventosPagar";
            this.comboEventosPagar.Size = new System.Drawing.Size(262, 28);
            this.comboEventosPagar.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Font = new System.Drawing.Font("Gotham", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label19.Location = new System.Drawing.Point(419, 424);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(230, 19);
            this.label19.TabIndex = 34;
            this.label19.Text = "Seleccione Evento a Pagar:";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // btnPagarEvento
            // 
            this.btnPagarEvento.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPagarEvento.Font = new System.Drawing.Font("GothamMedium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarEvento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPagarEvento.Location = new System.Drawing.Point(610, 633);
            this.btnPagarEvento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPagarEvento.Name = "btnPagarEvento";
            this.btnPagarEvento.Size = new System.Drawing.Size(271, 43);
            this.btnPagarEvento.TabIndex = 36;
            this.btnPagarEvento.Text = "Pagar y Generar Factura";
            this.btnPagarEvento.UseVisualStyleBackColor = false;
            // 
            // comboEventosInvitados
            // 
            this.comboEventosInvitados.FormattingEnabled = true;
            this.comboEventosInvitados.Location = new System.Drawing.Point(979, 450);
            this.comboEventosInvitados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboEventosInvitados.Name = "comboEventosInvitados";
            this.comboEventosInvitados.Size = new System.Drawing.Size(262, 28);
            this.comboEventosInvitados.TabIndex = 39;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Font = new System.Drawing.Font("Gotham", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label21.Location = new System.Drawing.Point(981, 425);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(164, 19);
            this.label21.TabIndex = 38;
            this.label21.Text = "Seleccione Evento:";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // dataListaInvitados
            // 
            this.dataListaInvitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaInvitados.Location = new System.Drawing.Point(979, 490);
            this.dataListaInvitados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataListaInvitados.Name = "dataListaInvitados";
            this.dataListaInvitados.RowHeadersWidth = 62;
            this.dataListaInvitados.Size = new System.Drawing.Size(262, 129);
            this.dataListaInvitados.TabIndex = 41;
            // 
            // txtNomEvento
            // 
            this.txtNomEvento.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomEvento.Location = new System.Drawing.Point(87, 141);
            this.txtNomEvento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomEvento.Name = "txtNomEvento";
            this.txtNomEvento.Size = new System.Drawing.Size(239, 26);
            this.txtNomEvento.TabIndex = 1;
            // 
            // btnGuardarEvento
            // 
            this.btnGuardarEvento.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarEvento.Font = new System.Drawing.Font("GothamMedium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEvento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEvento.Location = new System.Drawing.Point(126, 325);
            this.btnGuardarEvento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarEvento.Name = "btnGuardarEvento";
            this.btnGuardarEvento.Size = new System.Drawing.Size(197, 43);
            this.btnGuardarEvento.TabIndex = 2;
            this.btnGuardarEvento.Text = "Guardar Evento";
            this.btnGuardarEvento.UseVisualStyleBackColor = false;
            // 
            // datePicker
            // 
            this.datePicker.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.datePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(87, 206);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(239, 26);
            this.datePicker.TabIndex = 3;
            // 
            // dataGridEventos
            // 
            this.dataGridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEventos.Location = new System.Drawing.Point(415, 141);
            this.dataGridEventos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridEventos.Name = "dataGridEventos";
            this.dataGridEventos.RowHeadersWidth = 62;
            this.dataGridEventos.Size = new System.Drawing.Size(474, 158);
            this.dataGridEventos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Gotham", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(89, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre del Evento:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Gotham", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(90, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seleccione una Fecha:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Gotham", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(90, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ingrese una Ubicacion:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtUbicaEve
            // 
            this.txtUbicaEve.Location = new System.Drawing.Point(85, 271);
            this.txtUbicaEve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUbicaEve.Name = "txtUbicaEve";
            this.txtUbicaEve.Size = new System.Drawing.Size(239, 26);
            this.txtUbicaEve.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Gotham", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(415, 308);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "Seleccione Evento a Eliminar:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboEventosEliminar
            // 
            this.comboEventosEliminar.FormattingEnabled = true;
            this.comboEventosEliminar.Location = new System.Drawing.Point(415, 335);
            this.comboEventosEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboEventosEliminar.Name = "comboEventosEliminar";
            this.comboEventosEliminar.Size = new System.Drawing.Size(262, 28);
            this.comboEventosEliminar.TabIndex = 43;
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarEvento.Font = new System.Drawing.Font("GothamMedium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEvento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarEvento.Location = new System.Drawing.Point(701, 328);
            this.btnEliminarEvento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(188, 43);
            this.btnEliminarEvento.TabIndex = 44;
            this.btnEliminarEvento.Text = "Eliminar Evento";
            this.btnEliminarEvento.UseVisualStyleBackColor = false;
            // 
            // btnVerInvitados
            // 
            this.btnVerInvitados.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerInvitados.Font = new System.Drawing.Font("GothamMedium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerInvitados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerInvitados.Location = new System.Drawing.Point(1053, 629);
            this.btnVerInvitados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerInvitados.Name = "btnVerInvitados";
            this.btnVerInvitados.Size = new System.Drawing.Size(188, 43);
            this.btnVerInvitados.TabIndex = 33;
            this.btnVerInvitados.Text = "Ver Invitados";
            this.btnVerInvitados.UseVisualStyleBackColor = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this.btnEliminarEvento);
            this.Controls.Add(this.comboEventosEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataListaInvitados);
            this.Controls.Add(this.comboEventosInvitados);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnPagarEvento);
            this.Controls.Add(this.comboEventosPagar);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnVerInvitados);
            this.Controls.Add(this.btnAgregarInvitado);
            this.Controls.Add(this.dataGridFacturas);
            this.Controls.Add(this.txtEmailInvi);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtApellidoInvi);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtNombreInvi);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboEventosInvi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnContratarServicio);
            this.Controls.Add(this.txtCantidadServ);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboServicios);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboEventosContr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUbicaEve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridEventos);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnGuardarEvento);
            this.Controls.Add(this.txtNomEvento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaInvitados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboEventosContr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboServicios;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCantidadServ;
        private System.Windows.Forms.Button btnContratarServicio;
        private System.Windows.Forms.ComboBox comboEventosInvi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNombreInvi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtApellidoInvi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtEmailInvi;
        private System.Windows.Forms.DataGridView dataGridFacturas;
        private System.Windows.Forms.Button btnAgregarInvitado;
        private System.Windows.Forms.ComboBox comboEventosPagar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnPagarEvento;
        private System.Windows.Forms.ComboBox comboEventosInvitados;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dataListaInvitados;
        private System.Windows.Forms.TextBox txtNomEvento;
        private System.Windows.Forms.Button btnGuardarEvento;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DataGridView dataGridEventos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUbicaEve;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboEventosEliminar;
        private System.Windows.Forms.Button btnEliminarEvento;
        private System.Windows.Forms.Button btnVerInvitados;
    }
}