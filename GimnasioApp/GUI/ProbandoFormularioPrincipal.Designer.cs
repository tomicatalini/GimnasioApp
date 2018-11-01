namespace GimnasioApp
{
    partial class ProbandoFormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProbandoFormularioPrincipal));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.flowMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelIncio = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.imageListMenu = new System.Windows.Forms.ImageList(this.components);
            this.panelSocio = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSocio = new System.Windows.Forms.Button();
            this.btnAltaSocio = new System.Windows.Forms.Button();
            this.btnModificarSocio = new System.Windows.Forms.Button();
            this.btnVerSocio = new System.Windows.Forms.Button();
            this.btnBajaSocio = new System.Windows.Forms.Button();
            this.btnAltaFicha = new System.Windows.Forms.Button();
            this.btnModificarFicha = new System.Windows.Forms.Button();
            this.panelCuota = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCuota = new System.Windows.Forms.Button();
            this.panelRutina = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRutina = new System.Windows.Forms.Button();
            this.panelProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnComprarProd = new System.Windows.Forms.Button();
            this.btnVenderProd = new System.Windows.Forms.Button();
            this.panelGestion = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGestion = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.flowMenu.SuspendLayout();
            this.panelIncio.SuspendLayout();
            this.panelSocio.SuspendLayout();
            this.panelCuota.SuspendLayout();
            this.panelRutina.SuspendLayout();
            this.panelProductos.SuspendLayout();
            this.panelGestion.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLateral.Controls.Add(this.btnSalir);
            this.panelLateral.Controls.Add(this.flowMenu);
            this.panelLateral.Controls.Add(this.panelLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(232, 661);
            this.panelLateral.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(6, 592);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(220, 50);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // flowMenu
            // 
            this.flowMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowMenu.Controls.Add(this.panelIncio);
            this.flowMenu.Controls.Add(this.panelSocio);
            this.flowMenu.Controls.Add(this.panelCuota);
            this.flowMenu.Controls.Add(this.panelRutina);
            this.flowMenu.Controls.Add(this.panelProductos);
            this.flowMenu.Controls.Add(this.panelGestion);
            this.flowMenu.Location = new System.Drawing.Point(3, 123);
            this.flowMenu.Name = "flowMenu";
            this.flowMenu.Size = new System.Drawing.Size(226, 466);
            this.flowMenu.TabIndex = 0;
            // 
            // panelIncio
            // 
            this.panelIncio.Controls.Add(this.btnInicio);
            this.panelIncio.Location = new System.Drawing.Point(2, 2);
            this.panelIncio.Margin = new System.Windows.Forms.Padding(2);
            this.panelIncio.Name = "panelIncio";
            this.panelIncio.Size = new System.Drawing.Size(220, 50);
            this.panelIncio.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.ImageKey = "inicio2.png";
            this.btnInicio.ImageList = this.imageListMenu;
            this.btnInicio.Location = new System.Drawing.Point(2, 2);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(220, 50);
            this.btnInicio.TabIndex = 22;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.ActivarBotonMenu_Click);
            // 
            // imageListMenu
            // 
            this.imageListMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMenu.ImageStream")));
            this.imageListMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMenu.Images.SetKeyName(0, "gestion.png");
            this.imageListMenu.Images.SetKeyName(1, "inicio.png");
            this.imageListMenu.Images.SetKeyName(2, "producto.png");
            this.imageListMenu.Images.SetKeyName(3, "rutina.png");
            this.imageListMenu.Images.SetKeyName(4, "socio.png");
            this.imageListMenu.Images.SetKeyName(5, "gestion2.png");
            this.imageListMenu.Images.SetKeyName(6, "inicio2.png");
            this.imageListMenu.Images.SetKeyName(7, "producto2.png");
            this.imageListMenu.Images.SetKeyName(8, "rutina2.png");
            this.imageListMenu.Images.SetKeyName(9, "socio2.png");
            this.imageListMenu.Images.SetKeyName(10, "cheque2.png");
            this.imageListMenu.Images.SetKeyName(11, "cheque.png");
            // 
            // panelSocio
            // 
            this.panelSocio.Controls.Add(this.btnSocio);
            this.panelSocio.Controls.Add(this.btnAltaSocio);
            this.panelSocio.Controls.Add(this.btnModificarSocio);
            this.panelSocio.Controls.Add(this.btnVerSocio);
            this.panelSocio.Controls.Add(this.btnBajaSocio);
            this.panelSocio.Controls.Add(this.btnAltaFicha);
            this.panelSocio.Controls.Add(this.btnModificarFicha);
            this.panelSocio.Location = new System.Drawing.Point(2, 56);
            this.panelSocio.Margin = new System.Windows.Forms.Padding(2);
            this.panelSocio.Name = "panelSocio";
            this.panelSocio.Size = new System.Drawing.Size(220, 50);
            this.panelSocio.TabIndex = 0;
            // 
            // btnSocio
            // 
            this.btnSocio.BackColor = System.Drawing.Color.White;
            this.btnSocio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSocio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSocio.FlatAppearance.BorderSize = 0;
            this.btnSocio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            this.btnSocio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            this.btnSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocio.ImageKey = "socio.png";
            this.btnSocio.ImageList = this.imageListMenu;
            this.btnSocio.Location = new System.Drawing.Point(0, 0);
            this.btnSocio.Margin = new System.Windows.Forms.Padding(0);
            this.btnSocio.Name = "btnSocio";
            this.btnSocio.Size = new System.Drawing.Size(220, 50);
            this.btnSocio.TabIndex = 4;
            this.btnSocio.Text = "Socio";
            this.btnSocio.UseVisualStyleBackColor = false;
            this.btnSocio.Click += new System.EventHandler(this.ActivarBotonMenu_Click);
            // 
            // btnAltaSocio
            // 
            this.btnAltaSocio.BackColor = System.Drawing.Color.White;
            this.btnAltaSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAltaSocio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAltaSocio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAltaSocio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAltaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaSocio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaSocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaSocio.ImageIndex = 0;
            this.btnAltaSocio.Location = new System.Drawing.Point(18, 52);
            this.btnAltaSocio.Margin = new System.Windows.Forms.Padding(18, 2, 1, 1);
            this.btnAltaSocio.Name = "btnAltaSocio";
            this.btnAltaSocio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAltaSocio.Size = new System.Drawing.Size(200, 30);
            this.btnAltaSocio.TabIndex = 5;
            this.btnAltaSocio.Text = "Nuevo Socio";
            this.btnAltaSocio.UseVisualStyleBackColor = false;
            // 
            // btnModificarSocio
            // 
            this.btnModificarSocio.BackColor = System.Drawing.Color.White;
            this.btnModificarSocio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarSocio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarSocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarSocio.Location = new System.Drawing.Point(18, 85);
            this.btnModificarSocio.Margin = new System.Windows.Forms.Padding(18, 2, 1, 1);
            this.btnModificarSocio.Name = "btnModificarSocio";
            this.btnModificarSocio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModificarSocio.Size = new System.Drawing.Size(200, 30);
            this.btnModificarSocio.TabIndex = 9;
            this.btnModificarSocio.Text = "Modificar Datos Socio";
            this.btnModificarSocio.UseVisualStyleBackColor = false;
            // 
            // btnVerSocio
            // 
            this.btnVerSocio.BackColor = System.Drawing.Color.White;
            this.btnVerSocio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSocio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerSocio.Location = new System.Drawing.Point(18, 118);
            this.btnVerSocio.Margin = new System.Windows.Forms.Padding(18, 2, 1, 1);
            this.btnVerSocio.Name = "btnVerSocio";
            this.btnVerSocio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVerSocio.Size = new System.Drawing.Size(200, 30);
            this.btnVerSocio.TabIndex = 11;
            this.btnVerSocio.Text = "Informacion Socio";
            this.btnVerSocio.UseVisualStyleBackColor = false;
            // 
            // btnBajaSocio
            // 
            this.btnBajaSocio.BackColor = System.Drawing.Color.White;
            this.btnBajaSocio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBajaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaSocio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaSocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaSocio.Location = new System.Drawing.Point(18, 151);
            this.btnBajaSocio.Margin = new System.Windows.Forms.Padding(18, 2, 1, 1);
            this.btnBajaSocio.Name = "btnBajaSocio";
            this.btnBajaSocio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBajaSocio.Size = new System.Drawing.Size(200, 30);
            this.btnBajaSocio.TabIndex = 13;
            this.btnBajaSocio.Text = "Dar de Baja Socio";
            this.btnBajaSocio.UseVisualStyleBackColor = false;
            // 
            // btnAltaFicha
            // 
            this.btnAltaFicha.BackColor = System.Drawing.Color.White;
            this.btnAltaFicha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAltaFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaFicha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaFicha.Location = new System.Drawing.Point(18, 192);
            this.btnAltaFicha.Margin = new System.Windows.Forms.Padding(18, 10, 1, 1);
            this.btnAltaFicha.Name = "btnAltaFicha";
            this.btnAltaFicha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAltaFicha.Size = new System.Drawing.Size(200, 30);
            this.btnAltaFicha.TabIndex = 15;
            this.btnAltaFicha.Text = "Nueva Ficha Medica";
            this.btnAltaFicha.UseVisualStyleBackColor = false;
            // 
            // btnModificarFicha
            // 
            this.btnModificarFicha.BackColor = System.Drawing.Color.White;
            this.btnModificarFicha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarFicha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarFicha.Location = new System.Drawing.Point(18, 225);
            this.btnModificarFicha.Margin = new System.Windows.Forms.Padding(18, 2, 1, 1);
            this.btnModificarFicha.Name = "btnModificarFicha";
            this.btnModificarFicha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModificarFicha.Size = new System.Drawing.Size(200, 30);
            this.btnModificarFicha.TabIndex = 17;
            this.btnModificarFicha.Text = "Modificar Ficha Medica";
            this.btnModificarFicha.UseVisualStyleBackColor = false;
            // 
            // panelCuota
            // 
            this.panelCuota.Controls.Add(this.btnCuota);
            this.panelCuota.Location = new System.Drawing.Point(2, 110);
            this.panelCuota.Margin = new System.Windows.Forms.Padding(2);
            this.panelCuota.Name = "panelCuota";
            this.panelCuota.Size = new System.Drawing.Size(220, 50);
            this.panelCuota.TabIndex = 0;
            // 
            // btnCuota
            // 
            this.btnCuota.BackColor = System.Drawing.Color.White;
            this.btnCuota.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCuota.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCuota.FlatAppearance.BorderSize = 0;
            this.btnCuota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            this.btnCuota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            this.btnCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuota.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuota.ImageKey = "cheque.png";
            this.btnCuota.ImageList = this.imageListMenu;
            this.btnCuota.Location = new System.Drawing.Point(0, 0);
            this.btnCuota.Margin = new System.Windows.Forms.Padding(0);
            this.btnCuota.Name = "btnCuota";
            this.btnCuota.Size = new System.Drawing.Size(220, 50);
            this.btnCuota.TabIndex = 6;
            this.btnCuota.Text = "Cuota";
            this.btnCuota.UseVisualStyleBackColor = false;
            // 
            // panelRutina
            // 
            this.panelRutina.Controls.Add(this.btnRutina);
            this.panelRutina.Location = new System.Drawing.Point(2, 164);
            this.panelRutina.Margin = new System.Windows.Forms.Padding(2);
            this.panelRutina.Name = "panelRutina";
            this.panelRutina.Size = new System.Drawing.Size(220, 50);
            this.panelRutina.TabIndex = 0;
            // 
            // btnRutina
            // 
            this.btnRutina.BackColor = System.Drawing.Color.White;
            this.btnRutina.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRutina.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRutina.FlatAppearance.BorderSize = 0;
            this.btnRutina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            this.btnRutina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            this.btnRutina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutina.ImageKey = "rutina.png";
            this.btnRutina.ImageList = this.imageListMenu;
            this.btnRutina.Location = new System.Drawing.Point(0, 0);
            this.btnRutina.Margin = new System.Windows.Forms.Padding(0);
            this.btnRutina.Name = "btnRutina";
            this.btnRutina.Size = new System.Drawing.Size(220, 50);
            this.btnRutina.TabIndex = 6;
            this.btnRutina.Text = "Rutina";
            this.btnRutina.UseVisualStyleBackColor = false;
            // 
            // panelProductos
            // 
            this.panelProductos.Controls.Add(this.btnProducto);
            this.panelProductos.Controls.Add(this.btnComprarProd);
            this.panelProductos.Controls.Add(this.btnVenderProd);
            this.panelProductos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelProductos.Location = new System.Drawing.Point(2, 218);
            this.panelProductos.Margin = new System.Windows.Forms.Padding(2);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(220, 150);
            this.panelProductos.TabIndex = 0;
            this.panelProductos.WrapContents = false;
            // 
            // btnProducto
            // 
            this.btnProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProducto.BackColor = System.Drawing.Color.White;
            this.btnProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            this.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.ImageKey = "producto.png";
            this.btnProducto.ImageList = this.imageListMenu;
            this.btnProducto.Location = new System.Drawing.Point(0, 0);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(220, 50);
            this.btnProducto.TabIndex = 6;
            this.btnProducto.Text = "Productos";
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.ActivarBotonMenu_Click);
            this.btnProducto.Enter += new System.EventHandler(this.btnProducto_click);
            // 
            // btnComprarProd
            // 
            this.btnComprarProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnComprarProd.BackColor = System.Drawing.Color.White;
            this.btnComprarProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnComprarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprarProd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprarProd.Location = new System.Drawing.Point(18, 54);
            this.btnComprarProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnComprarProd.Name = "btnComprarProd";
            this.btnComprarProd.Size = new System.Drawing.Size(200, 30);
            this.btnComprarProd.TabIndex = 21;
            this.btnComprarProd.Text = "Comprar Productos";
            this.btnComprarProd.UseVisualStyleBackColor = false;
            this.btnComprarProd.Click += new System.EventHandler(this.btnComprarProd_Click);
            // 
            // btnVenderProd
            // 
            this.btnVenderProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnVenderProd.BackColor = System.Drawing.Color.White;
            this.btnVenderProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVenderProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderProd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenderProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenderProd.Location = new System.Drawing.Point(18, 88);
            this.btnVenderProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnVenderProd.Name = "btnVenderProd";
            this.btnVenderProd.Size = new System.Drawing.Size(200, 30);
            this.btnVenderProd.TabIndex = 22;
            this.btnVenderProd.Text = "Vender Productos";
            this.btnVenderProd.UseVisualStyleBackColor = false;
            // 
            // panelGestion
            // 
            this.panelGestion.Controls.Add(this.btnGestion);
            this.panelGestion.Location = new System.Drawing.Point(2, 372);
            this.panelGestion.Margin = new System.Windows.Forms.Padding(2);
            this.panelGestion.Name = "panelGestion";
            this.panelGestion.Size = new System.Drawing.Size(220, 50);
            this.panelGestion.TabIndex = 0;
            // 
            // btnGestion
            // 
            this.btnGestion.BackColor = System.Drawing.Color.White;
            this.btnGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGestion.FlatAppearance.BorderSize = 0;
            this.btnGestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            this.btnGestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestion.ImageKey = "gestion.png";
            this.btnGestion.ImageList = this.imageListMenu;
            this.btnGestion.Location = new System.Drawing.Point(0, 0);
            this.btnGestion.Margin = new System.Windows.Forms.Padding(0);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(220, 50);
            this.btnGestion.TabIndex = 5;
            this.btnGestion.Text = "Gestion";
            this.btnGestion.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(232, 101);
            this.panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logo Gimnasio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Location = new System.Drawing.Point(245, 10);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(10, 1, 0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(939, 651);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Click += new System.EventHandler(this.btnInicio_click);
            // 
            // ProbandoFormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelLateral);
            this.Name = "ProbandoFormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProbandoFormularioPrincipal";
            this.panelLateral.ResumeLayout(false);
            this.flowMenu.ResumeLayout(false);
            this.panelIncio.ResumeLayout(false);
            this.panelSocio.ResumeLayout(false);
            this.panelCuota.ResumeLayout(false);
            this.panelRutina.ResumeLayout(false);
            this.panelProductos.ResumeLayout(false);
            this.panelGestion.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSalir;
        protected System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.FlowLayoutPanel flowMenu;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageListMenu;
        private System.Windows.Forms.FlowLayoutPanel panelSocio;
        private System.Windows.Forms.Button btnSocio;
        private System.Windows.Forms.Button btnAltaSocio;
        private System.Windows.Forms.Button btnModificarSocio;
        private System.Windows.Forms.Button btnVerSocio;
        private System.Windows.Forms.Button btnBajaSocio;
        private System.Windows.Forms.Button btnAltaFicha;
        private System.Windows.Forms.Button btnModificarFicha;
        private System.Windows.Forms.FlowLayoutPanel panelProductos;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnComprarProd;
        private System.Windows.Forms.Button btnVenderProd;
        private System.Windows.Forms.FlowLayoutPanel panelRutina;
        private System.Windows.Forms.Button btnRutina;
        private System.Windows.Forms.FlowLayoutPanel panelGestion;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.FlowLayoutPanel panelCuota;
        private System.Windows.Forms.Button btnCuota;
        private System.Windows.Forms.FlowLayoutPanel panelIncio;
    }
}