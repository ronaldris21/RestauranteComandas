namespace ProyectoFinal
{
    partial class RestaurantePadre
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ssrLogin = new System.Windows.Forms.StatusStrip();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRestaurante = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.tsrRestaurante = new System.Windows.Forms.ToolStrip();
            this.tsrtxtBienvenido = new System.Windows.Forms.ToolStripTextBox();
            this.picMesero = new System.Windows.Forms.PictureBox();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.errMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.rdoMesero = new System.Windows.Forms.RadioButton();
            this.tsrRestaurante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMesero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // ssrLogin
            // 
            this.ssrLogin.Location = new System.Drawing.Point(0, 310);
            this.ssrLogin.Name = "ssrLogin";
            this.ssrLogin.Size = new System.Drawing.Size(476, 22);
            this.ssrLogin.TabIndex = 0;
            this.ssrLogin.Text = "statusStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(266, 271);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblRestaurante
            // 
            this.lblRestaurante.AutoSize = true;
            this.lblRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurante.Location = new System.Drawing.Point(72, 32);
            this.lblRestaurante.Name = "lblRestaurante";
            this.lblRestaurante.Size = new System.Drawing.Size(342, 31);
            this.lblRestaurante.TabIndex = 2;
            this.lblRestaurante.Text = "Restaurante Sal y Pimienta";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.Location = new System.Drawing.Point(135, 75);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(233, 25);
            this.lblSlogan.TabIndex = 3;
            this.lblSlogan.Text = "Mil sabores, un sólo lugar";
            // 
            // tsrRestaurante
            // 
            this.tsrRestaurante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrtxtBienvenido});
            this.tsrRestaurante.Location = new System.Drawing.Point(0, 0);
            this.tsrRestaurante.Name = "tsrRestaurante";
            this.tsrRestaurante.Size = new System.Drawing.Size(476, 25);
            this.tsrRestaurante.TabIndex = 5;
            this.tsrRestaurante.Text = "toolStrip1";
            // 
            // tsrtxtBienvenido
            // 
            this.tsrtxtBienvenido.Name = "tsrtxtBienvenido";
            this.tsrtxtBienvenido.Size = new System.Drawing.Size(100, 25);
            this.tsrtxtBienvenido.Text = "¡Bienvenido!";
            // 
            // picMesero
            // 
            this.picMesero.Image = global::ProyectoFinal.Properties.Resources.Waiter;
            this.picMesero.Location = new System.Drawing.Point(360, 196);
            this.picMesero.Name = "picMesero";
            this.picMesero.Size = new System.Drawing.Size(54, 48);
            this.picMesero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMesero.TabIndex = 7;
            this.picMesero.TabStop = false;
            // 
            // picAdmin
            // 
            this.picAdmin.Image = global::ProyectoFinal.Properties.Resources.Admin;
            this.picAdmin.Location = new System.Drawing.Point(360, 140);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(54, 50);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdmin.TabIndex = 6;
            this.picAdmin.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(149, 164);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(66, 164);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 16);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(66, 197);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(77, 16);
            this.lblContraseña.TabIndex = 11;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(149, 196);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.ShortcutsEnabled = false;
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 12;
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(140, 271);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(75, 23);
            this.btnAcceder.TabIndex = 13;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // errMensaje
            // 
            this.errMensaje.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errMensaje.ContainerControl = this;
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Checked = true;
            this.rdoAdmin.Location = new System.Drawing.Point(287, 166);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(54, 17);
            this.rdoAdmin.TabIndex = 16;
            this.rdoAdmin.TabStop = true;
            this.rdoAdmin.Text = "Admin";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // rdoMesero
            // 
            this.rdoMesero.AutoSize = true;
            this.rdoMesero.Location = new System.Drawing.Point(287, 207);
            this.rdoMesero.Name = "rdoMesero";
            this.rdoMesero.Size = new System.Drawing.Size(60, 17);
            this.rdoMesero.TabIndex = 17;
            this.rdoMesero.Text = "Mesero";
            this.rdoMesero.UseVisualStyleBackColor = true;
            // 
            // RestaurantePadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 332);
            this.Controls.Add(this.rdoMesero);
            this.Controls.Add(this.rdoAdmin);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.picMesero);
            this.Controls.Add(this.picAdmin);
            this.Controls.Add(this.tsrRestaurante);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lblRestaurante);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.ssrLogin);
            this.Name = "RestaurantePadre";
            this.Text = "Restaurante";
            this.tsrRestaurante.ResumeLayout(false);
            this.tsrRestaurante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMesero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMensaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssrLogin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRestaurante;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.ToolStrip tsrRestaurante;
        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.PictureBox picMesero;
        private System.Windows.Forms.ToolStripTextBox tsrtxtBienvenido;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.ErrorProvider errMensaje;
        private System.Windows.Forms.RadioButton rdoMesero;
        private System.Windows.Forms.RadioButton rdoAdmin;
        }
}

