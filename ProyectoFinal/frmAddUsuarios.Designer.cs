namespace ProyectoFinal
    {
    partial class frmAddUsuarios
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
            this.lblBienvenidoAdmin = new System.Windows.Forms.Label();
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.tipBienvenido = new System.Windows.Forms.ToolStrip();
            this.tsrlblConfig = new System.Windows.Forms.ToolStripLabel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnContra = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.errMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tipBienvenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMensaje)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenidoAdmin
            // 
            this.lblBienvenidoAdmin.AutoSize = true;
            this.lblBienvenidoAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidoAdmin.Location = new System.Drawing.Point(149, 22);
            this.lblBienvenidoAdmin.Name = "lblBienvenidoAdmin";
            this.lblBienvenidoAdmin.Size = new System.Drawing.Size(239, 25);
            this.lblBienvenidoAdmin.TabIndex = 0;
            this.lblBienvenidoAdmin.Text = "Bienvenido, Administrador";
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicaciones.Location = new System.Drawing.Point(140, 60);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(261, 20);
            this.lblIndicaciones.TabIndex = 3;
            this.lblIndicaciones.Text = "Puede agregar y/o eliminar meseros";
            // 
            // tipBienvenido
            // 
            this.tipBienvenido.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrlblConfig});
            this.tipBienvenido.Location = new System.Drawing.Point(0, 0);
            this.tipBienvenido.Name = "tipBienvenido";
            this.tipBienvenido.Size = new System.Drawing.Size(570, 25);
            this.tipBienvenido.TabIndex = 5;
            this.tipBienvenido.Text = "toolStrip1";
            // 
            // tsrlblConfig
            // 
            this.tsrlblConfig.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tsrlblConfig.Name = "tsrlblConfig";
            this.tsrlblConfig.Size = new System.Drawing.Size(220, 22);
            this.tsrlblConfig.Text = "Es momento de configurar el restaurante:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvUsuarios.Location = new System.Drawing.Point(26, 179);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(444, 153);
            this.dgvUsuarios.TabIndex = 31;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Usuario";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Contraseña";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Eliminar";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Text = "Eliminar";
            this.Column4.UseColumnTextForButtonValue = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(285, 119);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(110, 150);
            this.txtContra.Name = "txtContra";
            this.txtContra.ShortcutsEnabled = false;
            this.txtContra.Size = new System.Drawing.Size(123, 20);
            this.txtContra.TabIndex = 29;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(110, 124);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ShortcutsEnabled = false;
            this.txtUsuario.Size = new System.Drawing.Size(123, 20);
            this.txtUsuario.TabIndex = 28;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(123, 20);
            this.txtNombre.TabIndex = 27;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnContra
            // 
            this.btnContra.AutoSize = true;
            this.btnContra.Location = new System.Drawing.Point(39, 150);
            this.btnContra.Name = "btnContra";
            this.btnContra.Size = new System.Drawing.Size(61, 13);
            this.btnContra.TabIndex = 26;
            this.btnContra.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(39, 124);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 25;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 98);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre";
            // 
            // errMensaje
            // 
            this.errMensaje.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errMensaje.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lblBienvenidoAdmin);
            this.panel1.Controls.Add(this.dgvUsuarios);
            this.panel1.Controls.Add(this.lblIndicaciones);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtContra);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.btnContra);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Location = new System.Drawing.Point(32, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 383);
            this.panel1.TabIndex = 32;
            // 
            // frmAddUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(570, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tipBienvenido);
            this.Name = "frmAddUsuarios";
            this.Text = "AddRemMeseros";
            this.Load += new System.EventHandler(this.AddUsuarios_Load);
            this.tipBienvenido.ResumeLayout(false);
            this.tipBienvenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMensaje)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label lblBienvenidoAdmin;
        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.ToolStrip tipBienvenido;
        private System.Windows.Forms.ToolStripLabel tsrlblConfig;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label btnContra;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ErrorProvider errMensaje;
        private System.Windows.Forms.Panel panel1;
    }
    }