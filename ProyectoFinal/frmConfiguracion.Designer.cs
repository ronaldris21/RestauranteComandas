namespace ProyectoFinal
{
    partial class frmConfiguracion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMesas = new System.Windows.Forms.NumericUpDown();
            this.nudPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.errMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMensaje)).BeginInit();
            this.pnlConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de mesas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "% de propinas";
            // 
            // nudMesas
            // 
            this.nudMesas.Location = new System.Drawing.Point(172, 43);
            this.nudMesas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMesas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMesas.Name = "nudMesas";
            this.nudMesas.Size = new System.Drawing.Size(60, 20);
            this.nudMesas.TabIndex = 2;
            this.nudMesas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPorcentaje
            // 
            this.nudPorcentaje.DecimalPlaces = 2;
            this.nudPorcentaje.Location = new System.Drawing.Point(172, 75);
            this.nudPorcentaje.Name = "nudPorcentaje";
            this.nudPorcentaje.Size = new System.Drawing.Size(60, 20);
            this.nudPorcentaje.TabIndex = 3;
            this.nudPorcentaje.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(145, 139);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.ShortcutsEnabled = false;
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 16;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(62, 140);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(77, 16);
            this.lblContraseña.TabIndex = 15;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(62, 108);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 16);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(145, 108);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(172, 183);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(65, 183);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(70, 25);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // errMensaje
            // 
            this.errMensaje.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errMensaje.ContainerControl = this;
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.lblAdvertencia);
            this.pnlConfig.Controls.Add(this.nudMesas);
            this.pnlConfig.Controls.Add(this.btnActualizar);
            this.pnlConfig.Controls.Add(this.label1);
            this.pnlConfig.Controls.Add(this.btnSalir);
            this.pnlConfig.Controls.Add(this.label2);
            this.pnlConfig.Controls.Add(this.txtContraseña);
            this.pnlConfig.Controls.Add(this.nudPorcentaje);
            this.pnlConfig.Controls.Add(this.lblContraseña);
            this.pnlConfig.Controls.Add(this.txtUsuario);
            this.pnlConfig.Controls.Add(this.lblUsuario);
            this.pnlConfig.Location = new System.Drawing.Point(12, 28);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(356, 251);
            this.pnlConfig.TabIndex = 19;
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Location = new System.Drawing.Point(16, 13);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(325, 13);
            this.lblAdvertencia.TabIndex = 20;
            this.lblAdvertencia.Text = "Recuerda que todas las mesas se volverán disponibles al modificar.";
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 305);
            this.Controls.Add(this.pnlConfig);
            this.Name = "frmConfiguracion";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMensaje)).EndInit();
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMesas;
        private System.Windows.Forms.NumericUpDown nudPorcentaje;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ErrorProvider errMensaje;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.Label lblAdvertencia;
    }
}