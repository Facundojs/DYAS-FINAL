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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomEvento = new System.Windows.Forms.TextBox();
            this.btnGuardarEvento = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridEventos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUbicaEve = new System.Windows.Forms.TextBox();
            this.txtHoraEv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboEventosContr = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboServicios = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCantidadServ = new System.Windows.Forms.TextBox();
            this.btnContratarServicio = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
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
            this.label20 = new System.Windows.Forms.Label();
            this.comboEventosInvitados = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dataListaInvitados = new System.Windows.Forms.DataGridView();
            this.btnEliminarEvento = new System.Windows.Forms.Button();
            this.comboEventosEliminar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaInvitados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(607, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eventos GA";
            // 
            // txtNomEvento
            // 
            this.txtNomEvento.Location = new System.Drawing.Point(154, 113);
            this.txtNomEvento.Name = "txtNomEvento";
            this.txtNomEvento.Size = new System.Drawing.Size(200, 20);
            this.txtNomEvento.TabIndex = 1;
            // 
            // btnGuardarEvento
            // 
            this.btnGuardarEvento.Location = new System.Drawing.Point(142, 267);
            this.btnGuardarEvento.Name = "btnGuardarEvento";
            this.btnGuardarEvento.Size = new System.Drawing.Size(106, 37);
            this.btnGuardarEvento.TabIndex = 2;
            this.btnGuardarEvento.Text = "Guardar Evento";
            this.btnGuardarEvento.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(154, 151);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 3;
            // 
            // dataGridEventos
            // 
            this.dataGridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEventos.Location = new System.Drawing.Point(397, 103);
            this.dataGridEventos.Name = "dataGridEventos";
            this.dataGridEventos.Size = new System.Drawing.Size(608, 175);
            this.dataGridEventos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Crear Nuevo Evento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre del Evento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seleccione una Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingrese un Horario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ingrese una Ubicacion:";
            // 
            // txtUbicaEve
            // 
            this.txtUbicaEve.Location = new System.Drawing.Point(154, 222);
            this.txtUbicaEve.Name = "txtUbicaEve";
            this.txtUbicaEve.Size = new System.Drawing.Size(200, 20);
            this.txtUbicaEve.TabIndex = 13;
            // 
            // txtHoraEv
            // 
            this.txtHoraEv.Location = new System.Drawing.Point(154, 188);
            this.txtHoraEv.Name = "txtHoraEv";
            this.txtHoraEv.Size = new System.Drawing.Size(200, 20);
            this.txtHoraEv.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Seleccione Evento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(121, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Contratar Servicios:";
            // 
            // comboEventosContr
            // 
            this.comboEventosContr.FormattingEnabled = true;
            this.comboEventosContr.Location = new System.Drawing.Point(202, 404);
            this.comboEventosContr.Name = "comboEventosContr";
            this.comboEventosContr.Size = new System.Drawing.Size(176, 21);
            this.comboEventosContr.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 447);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Seleccione Servicio a Contratar:";
            // 
            // comboServicios
            // 
            this.comboServicios.FormattingEnabled = true;
            this.comboServicios.Location = new System.Drawing.Point(202, 444);
            this.comboServicios.Name = "comboServicios";
            this.comboServicios.Size = new System.Drawing.Size(176, 21);
            this.comboServicios.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 484);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Cantidad:";
            // 
            // txtCantidadServ
            // 
            this.txtCantidadServ.Location = new System.Drawing.Point(202, 481);
            this.txtCantidadServ.Name = "txtCantidadServ";
            this.txtCantidadServ.Size = new System.Drawing.Size(176, 20);
            this.txtCantidadServ.TabIndex = 21;
            // 
            // btnContratarServicio
            // 
            this.btnContratarServicio.Location = new System.Drawing.Point(145, 523);
            this.btnContratarServicio.Name = "btnContratarServicio";
            this.btnContratarServicio.Size = new System.Drawing.Size(106, 37);
            this.btnContratarServicio.TabIndex = 22;
            this.btnContratarServicio.Text = "Contratar Servicio";
            this.btnContratarServicio.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1138, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Agregar Invitados:";
            // 
            // comboEventosInvi
            // 
            this.comboEventosInvi.FormattingEnabled = true;
            this.comboEventosInvi.Location = new System.Drawing.Point(1168, 108);
            this.comboEventosInvi.Name = "comboEventosInvi";
            this.comboEventosInvi.Size = new System.Drawing.Size(176, 21);
            this.comboEventosInvi.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1043, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Seleccione Evento:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1042, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Ingrese el Nombre:";
            // 
            // txtNombreInvi
            // 
            this.txtNombreInvi.Location = new System.Drawing.Point(1168, 148);
            this.txtNombreInvi.Name = "txtNombreInvi";
            this.txtNombreInvi.Size = new System.Drawing.Size(176, 20);
            this.txtNombreInvi.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1043, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Ingrese el Apellido:";
            // 
            // txtApellidoInvi
            // 
            this.txtApellidoInvi.Location = new System.Drawing.Point(1168, 188);
            this.txtApellidoInvi.Name = "txtApellidoInvi";
            this.txtApellidoInvi.Size = new System.Drawing.Size(176, 20);
            this.txtApellidoInvi.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1043, 229);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Ingrese el Email:";
            // 
            // txtEmailInvi
            // 
            this.txtEmailInvi.Location = new System.Drawing.Point(1168, 226);
            this.txtEmailInvi.Name = "txtEmailInvi";
            this.txtEmailInvi.Size = new System.Drawing.Size(176, 20);
            this.txtEmailInvi.TabIndex = 31;
            // 
            // dataGridFacturas
            // 
            this.dataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacturas.Location = new System.Drawing.Point(404, 518);
            this.dataGridFacturas.Name = "dataGridFacturas";
            this.dataGridFacturas.Size = new System.Drawing.Size(601, 95);
            this.dataGridFacturas.TabIndex = 32;
            // 
            // btnAgregarInvitado
            // 
            this.btnAgregarInvitado.Location = new System.Drawing.Point(1141, 278);
            this.btnAgregarInvitado.Name = "btnAgregarInvitado";
            this.btnAgregarInvitado.Size = new System.Drawing.Size(106, 37);
            this.btnAgregarInvitado.TabIndex = 33;
            this.btnAgregarInvitado.Text = "Agregar Invitado";
            this.btnAgregarInvitado.UseVisualStyleBackColor = true;
            // 
            // comboEventosPagar
            // 
            this.comboEventosPagar.FormattingEnabled = true;
            this.comboEventosPagar.Location = new System.Drawing.Point(578, 423);
            this.comboEventosPagar.Name = "comboEventosPagar";
            this.comboEventosPagar.Size = new System.Drawing.Size(176, 21);
            this.comboEventosPagar.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(432, 426);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Seleccione Evento a Pagar:";
            // 
            // btnPagarEvento
            // 
            this.btnPagarEvento.Location = new System.Drawing.Point(786, 418);
            this.btnPagarEvento.Name = "btnPagarEvento";
            this.btnPagarEvento.Size = new System.Drawing.Size(181, 28);
            this.btnPagarEvento.TabIndex = 36;
            this.btnPagarEvento.Text = "Pagar y Generar Factura";
            this.btnPagarEvento.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1125, 344);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(149, 16);
            this.label20.TabIndex = 37;
            this.label20.Text = "Ver Lista de Invitados:";
            // 
            // comboEventosInvitados
            // 
            this.comboEventosInvitados.FormattingEnabled = true;
            this.comboEventosInvitados.Location = new System.Drawing.Point(1168, 385);
            this.comboEventosInvitados.Name = "comboEventosInvitados";
            this.comboEventosInvitados.Size = new System.Drawing.Size(176, 21);
            this.comboEventosInvitados.TabIndex = 39;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1043, 388);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 13);
            this.label21.TabIndex = 38;
            this.label21.Text = "Seleccione Evento:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(646, 476);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 16);
            this.label22.TabIndex = 40;
            this.label22.Text = "Facturas / Pagos";
            // 
            // dataListaInvitados
            // 
            this.dataListaInvitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaInvitados.Location = new System.Drawing.Point(1046, 431);
            this.dataListaInvitados.Name = "dataListaInvitados";
            this.dataListaInvitados.Size = new System.Drawing.Size(298, 182);
            this.dataListaInvitados.TabIndex = 41;
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.Location = new System.Drawing.Point(786, 309);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(181, 28);
            this.btnEliminarEvento.TabIndex = 44;
            this.btnEliminarEvento.Text = "Eliminar Evento";
            this.btnEliminarEvento.UseVisualStyleBackColor = true;
            // 
            // comboEventosEliminar
            // 
            this.comboEventosEliminar.FormattingEnabled = true;
            this.comboEventosEliminar.Location = new System.Drawing.Point(578, 314);
            this.comboEventosEliminar.Name = "comboEventosEliminar";
            this.comboEventosEliminar.Size = new System.Drawing.Size(176, 21);
            this.comboEventosEliminar.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Seleccione Evento a Eliminar:";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 659);
            this.Controls.Add(this.btnEliminarEvento);
            this.Controls.Add(this.comboEventosEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataListaInvitados);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.comboEventosInvitados);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnPagarEvento);
            this.Controls.Add(this.comboEventosPagar);
            this.Controls.Add(this.label19);
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
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnContratarServicio);
            this.Controls.Add(this.txtCantidadServ);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboServicios);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboEventosContr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHoraEv);
            this.Controls.Add(this.txtUbicaEve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridEventos);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnGuardarEvento);
            this.Controls.Add(this.txtNomEvento);
            this.Controls.Add(this.label1);
            this.Name = "FormHome";
            this.Text = "FormHome";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaInvitados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomEvento;
        private System.Windows.Forms.Button btnGuardarEvento;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DataGridView dataGridEventos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUbicaEve;
        private System.Windows.Forms.TextBox txtHoraEv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboEventosContr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboServicios;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCantidadServ;
        private System.Windows.Forms.Button btnContratarServicio;
        private System.Windows.Forms.Label label14;
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
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboEventosInvitados;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dataListaInvitados;
        private System.Windows.Forms.Button btnEliminarEvento;
        private System.Windows.Forms.ComboBox comboEventosEliminar;
        private System.Windows.Forms.Label label7;
    }
}