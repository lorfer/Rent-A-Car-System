namespace GUI_MODERNISTA.Views
{
	partial class Alquiler
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
            this.components = new System.ComponentModel.Container();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbusuario = new System.Windows.Forms.Label();
            this.TTOTAL = new System.Windows.Forms.Label();
            this.dateFechaF = new System.Windows.Forms.DateTimePicker();
            this.dateFechaI = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpVehiculos = new System.Windows.Forms.TabPage();
            this.gridVehiculo = new System.Windows.Forms.DataGridView();
            this.idVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capPasajeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioAlquilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpCliente = new System.Windows.Forms.TabPage();
            this.tbAlquiler = new System.Windows.Forms.TabPage();
            this.gridAlquiler = new System.Windows.Forms.DataGridView();
            this.txtIdVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAlquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            this.tpCliente.SuspendLayout();
            this.tbAlquiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(124, 523);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(202, 35);
            this.btnAgregar.TabIndex = 37;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gridCliente
            // 
            this.gridCliente.AutoGenerateColumns = false;
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.tipoDocumentoDataGridViewTextBoxColumn,
            this.numDocumentoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.gridCliente.DataSource = this.clienteBindingSource;
            this.gridCliente.Location = new System.Drawing.Point(6, 25);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.Size = new System.Drawing.Size(964, 144);
            this.gridCliente.TabIndex = 36;
            this.gridCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCliente_CellClick);
            this.gridCliente.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridCliente_DataBindingComplete);
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            // 
            // tipoDocumentoDataGridViewTextBoxColumn
            // 
            this.tipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "TipoDocumento";
            this.tipoDocumentoDataGridViewTextBoxColumn.HeaderText = "TipoDocumento";
            this.tipoDocumentoDataGridViewTextBoxColumn.Name = "tipoDocumentoDataGridViewTextBoxColumn";
            // 
            // numDocumentoDataGridViewTextBoxColumn
            // 
            this.numDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NumDocumento";
            this.numDocumentoDataGridViewTextBoxColumn.HeaderText = "NumDocumento";
            this.numDocumentoDataGridViewTextBoxColumn.Name = "numDocumentoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(GUI_MODERNISTA.Models.Cliente);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(199, 176);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(113, 24);
            this.txtTelefono.TabIndex = 30;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(199, 132);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(253, 24);
            this.txtDocumento.TabIndex = 29;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(199, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 24);
            this.txtNombre.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(70, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "RNC/CEDULA";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(114, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(525, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fecha Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(529, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(452, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Rent-a-Car";
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuario.ForeColor = System.Drawing.Color.White;
            this.lbusuario.Location = new System.Drawing.Point(241, 46);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(68, 20);
            this.lbusuario.TabIndex = 38;
            this.lbusuario.Text = "usuario";
            // 
            // TTOTAL
            // 
            this.TTOTAL.AutoSize = true;
            this.TTOTAL.ForeColor = System.Drawing.Color.Transparent;
            this.TTOTAL.Location = new System.Drawing.Point(826, 500);
            this.TTOTAL.Name = "TTOTAL";
            this.TTOTAL.Size = new System.Drawing.Size(31, 13);
            this.TTOTAL.TabIndex = 39;
            this.TTOTAL.Text = "Total";
            // 
            // dateFechaF
            // 
            this.dateFechaF.Location = new System.Drawing.Point(638, 132);
            this.dateFechaF.Name = "dateFechaF";
            this.dateFechaF.Size = new System.Drawing.Size(249, 20);
            this.dateFechaF.TabIndex = 40;
            this.dateFechaF.ValueChanged += new System.EventHandler(this.dateFechaF_ValueChanged);
            // 
            // dateFechaI
            // 
            this.dateFechaI.Location = new System.Drawing.Point(638, 95);
            this.dateFechaI.Name = "dateFechaI";
            this.dateFechaI.Size = new System.Drawing.Size(249, 20);
            this.dateFechaI.TabIndex = 40;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpVehiculos);
            this.tabControl1.Controls.Add(this.tpCliente);
            this.tabControl1.Controls.Add(this.tbAlquiler);
            this.tabControl1.Location = new System.Drawing.Point(12, 280);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 217);
            this.tabControl1.TabIndex = 42;
            // 
            // tpVehiculos
            // 
            this.tpVehiculos.Controls.Add(this.gridVehiculo);
            this.tpVehiculos.Location = new System.Drawing.Point(4, 22);
            this.tpVehiculos.Name = "tpVehiculos";
            this.tpVehiculos.Padding = new System.Windows.Forms.Padding(3);
            this.tpVehiculos.Size = new System.Drawing.Size(1032, 191);
            this.tpVehiculos.TabIndex = 1;
            this.tpVehiculos.Text = "VEHICULOS";
            this.tpVehiculos.UseVisualStyleBackColor = true;
            // 
            // gridVehiculo
            // 
            this.gridVehiculo.AutoGenerateColumns = false;
            this.gridVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVehiculoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.capPasajeroDataGridViewTextBoxColumn,
            this.transmisionDataGridViewTextBoxColumn,
            this.combustibleDataGridViewTextBoxColumn,
            this.precioAlquilerDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.gridVehiculo.DataSource = this.vehiculoBindingSource;
            this.gridVehiculo.Location = new System.Drawing.Point(6, 6);
            this.gridVehiculo.Name = "gridVehiculo";
            this.gridVehiculo.Size = new System.Drawing.Size(1020, 179);
            this.gridVehiculo.TabIndex = 0;
            this.gridVehiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVehiculo_CellClick);
            // 
            // idVehiculoDataGridViewTextBoxColumn
            // 
            this.idVehiculoDataGridViewTextBoxColumn.DataPropertyName = "IdVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn.HeaderText = "IdVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn.Name = "idVehiculoDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // capPasajeroDataGridViewTextBoxColumn
            // 
            this.capPasajeroDataGridViewTextBoxColumn.DataPropertyName = "CapPasajero";
            this.capPasajeroDataGridViewTextBoxColumn.HeaderText = "CapPasajero";
            this.capPasajeroDataGridViewTextBoxColumn.Name = "capPasajeroDataGridViewTextBoxColumn";
            // 
            // transmisionDataGridViewTextBoxColumn
            // 
            this.transmisionDataGridViewTextBoxColumn.DataPropertyName = "Transmision";
            this.transmisionDataGridViewTextBoxColumn.HeaderText = "Transmision";
            this.transmisionDataGridViewTextBoxColumn.Name = "transmisionDataGridViewTextBoxColumn";
            // 
            // combustibleDataGridViewTextBoxColumn
            // 
            this.combustibleDataGridViewTextBoxColumn.DataPropertyName = "Combustible";
            this.combustibleDataGridViewTextBoxColumn.HeaderText = "Combustible";
            this.combustibleDataGridViewTextBoxColumn.Name = "combustibleDataGridViewTextBoxColumn";
            // 
            // precioAlquilerDataGridViewTextBoxColumn
            // 
            this.precioAlquilerDataGridViewTextBoxColumn.DataPropertyName = "PrecioAlquiler";
            this.precioAlquilerDataGridViewTextBoxColumn.HeaderText = "PrecioAlquiler";
            this.precioAlquilerDataGridViewTextBoxColumn.Name = "precioAlquilerDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataSource = typeof(GUI_MODERNISTA.Models.Vehiculo);
            // 
            // tpCliente
            // 
            this.tpCliente.Controls.Add(this.gridCliente);
            this.tpCliente.Location = new System.Drawing.Point(4, 22);
            this.tpCliente.Name = "tpCliente";
            this.tpCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tpCliente.Size = new System.Drawing.Size(1032, 191);
            this.tpCliente.TabIndex = 0;
            this.tpCliente.Text = "CLIENTES";
            this.tpCliente.UseVisualStyleBackColor = true;
            // 
            // tbAlquiler
            // 
            this.tbAlquiler.Controls.Add(this.gridAlquiler);
            this.tbAlquiler.Location = new System.Drawing.Point(4, 22);
            this.tbAlquiler.Name = "tbAlquiler";
            this.tbAlquiler.Padding = new System.Windows.Forms.Padding(3);
            this.tbAlquiler.Size = new System.Drawing.Size(1032, 191);
            this.tbAlquiler.TabIndex = 2;
            this.tbAlquiler.Text = "ALQUILER";
            this.tbAlquiler.UseVisualStyleBackColor = true;
            // 
            // gridAlquiler
            // 
            this.gridAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlquiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdVehiculo,
            this.txtTipo,
            this.txtMarca,
            this.txtModelo,
            this.txtAlquiler,
            this.txtStock,
            this.txtCantidad});
            this.gridAlquiler.Location = new System.Drawing.Point(6, 6);
            this.gridAlquiler.Name = "gridAlquiler";
            this.gridAlquiler.Size = new System.Drawing.Size(1020, 179);
            this.gridAlquiler.TabIndex = 0;
            // 
            // txtIdVehiculo
            // 
            this.txtIdVehiculo.HeaderText = "Código";
            this.txtIdVehiculo.Name = "txtIdVehiculo";
            this.txtIdVehiculo.ReadOnly = true;
            // 
            // txtTipo
            // 
            this.txtTipo.HeaderText = "Tipo";
            this.txtTipo.Name = "txtTipo";
            // 
            // txtMarca
            // 
            this.txtMarca.HeaderText = "Marca";
            this.txtMarca.Name = "txtMarca";
            // 
            // txtModelo
            // 
            this.txtModelo.HeaderText = "Modelo";
            this.txtModelo.Name = "txtModelo";
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.HeaderText = "Alquiler";
            this.txtAlquiler.Name = "txtAlquiler";
            // 
            // txtStock
            // 
            this.txtStock.HeaderText = "Stock";
            this.txtStock.Name = "txtStock";
            // 
            // txtCantidad
            // 
            this.txtCantidad.HeaderText = "Cantidad";
            this.txtCantidad.Name = "txtCantidad";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(863, 500);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(13, 13);
            this.lbTotal.TabIndex = 43;
            this.lbTotal.Text = "$";
            // 
            // Alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dateFechaI);
            this.Controls.Add(this.dateFechaF);
            this.Controls.Add(this.TTOTAL);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alquiler";
            this.Text = "Alquiler";
            this.Load += new System.EventHandler(this.Alquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpVehiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            this.tpCliente.ResumeLayout(false);
            this.tbAlquiler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.DataGridView gridCliente;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtDocumento;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbusuario;
		private System.Windows.Forms.Label TTOTAL;
		private System.Windows.Forms.DateTimePicker dateFechaF;
		private System.Windows.Forms.DateTimePicker dateFechaI;
		private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numDocumentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource clienteBindingSource;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpCliente;
		private System.Windows.Forms.TabPage tpVehiculos;
        private System.Windows.Forms.DataGridView gridVehiculo;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capPasajeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioAlquilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tbAlquiler;
        private System.Windows.Forms.DataGridView gridAlquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAlquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCantidad;
    }
}