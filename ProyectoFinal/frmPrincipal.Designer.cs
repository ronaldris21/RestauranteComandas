namespace ProyectoFinal
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComandas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsbtnUsuarios = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCrearMenu = new System.Windows.Forms.ToolStripButton();
            this.tsbtnComandas = new System.Windows.Forms.ToolStripButton();
            this.tsbtnConfig = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUsuarios,
            this.tsmiMenu,
            this.tsmiComandas,
            this.tsmiConfig,
            this.tsmiSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiUsuarios
            // 
            this.tsmiUsuarios.Name = "tsmiUsuarios";
            this.tsmiUsuarios.Size = new System.Drawing.Size(64, 20);
            this.tsmiUsuarios.Text = "Usuarios";
            // 
            // tsmiMenu
            // 
            this.tsmiMenu.Name = "tsmiMenu";
            this.tsmiMenu.Size = new System.Drawing.Size(50, 20);
            this.tsmiMenu.Text = "Menú";
            // 
            // tsmiComandas
            // 
            this.tsmiComandas.Name = "tsmiComandas";
            this.tsmiComandas.Size = new System.Drawing.Size(76, 20);
            this.tsmiComandas.Text = "Comandas";
            // 
            // tsmiConfig
            // 
            this.tsmiConfig.Name = "tsmiConfig";
            this.tsmiConfig.Size = new System.Drawing.Size(95, 20);
            this.tsmiConfig.Text = "Configuración";
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(41, 20);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(897, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // tsPrincipal
            // 
            this.tsPrincipal.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnUsuarios,
            this.tsbtnCrearMenu,
            this.tsbtnComandas,
            this.tsbtnConfig,
            this.toolStripLabel});
            this.tsPrincipal.Location = new System.Drawing.Point(0, 24);
            this.tsPrincipal.Margin = new System.Windows.Forms.Padding(5);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Size = new System.Drawing.Size(897, 54);
            this.tsPrincipal.TabIndex = 2;
            this.tsPrincipal.Text = "toolStrip1";
            // 
            // tsbtnUsuarios
            // 
            this.tsbtnUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUsuarios.Image")));
            this.tsbtnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUsuarios.Margin = new System.Windows.Forms.Padding(5);
            this.tsbtnUsuarios.Name = "tsbtnUsuarios";
            this.tsbtnUsuarios.Size = new System.Drawing.Size(44, 44);
            this.tsbtnUsuarios.Text = "toolStripButton1";
            this.tsbtnUsuarios.ToolTipText = "Usuarios";
            // 
            // tsbtnCrearMenu
            // 
            this.tsbtnCrearMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCrearMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCrearMenu.Image")));
            this.tsbtnCrearMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCrearMenu.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.tsbtnCrearMenu.Name = "tsbtnCrearMenu";
            this.tsbtnCrearMenu.Size = new System.Drawing.Size(44, 44);
            this.tsbtnCrearMenu.Text = "Menú";
            // 
            // tsbtnComandas
            // 
            this.tsbtnComandas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnComandas.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnComandas.Image")));
            this.tsbtnComandas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnComandas.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.tsbtnComandas.Name = "tsbtnComandas";
            this.tsbtnComandas.Size = new System.Drawing.Size(44, 44);
            this.tsbtnComandas.Text = "Comandas";
            // 
            // tsbtnConfig
            // 
            this.tsbtnConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnConfig.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConfig.Image")));
            this.tsbtnConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConfig.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.tsbtnConfig.Name = "tsbtnConfig";
            this.tsbtnConfig.Size = new System.Drawing.Size(44, 44);
            this.tsbtnConfig.Text = "Configuración";
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(122, 51);
            this.toolStripLabel.Text = "Barra de herramientas";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 467);
            this.Controls.Add(this.tsPrincipal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Restaurante Sal y Pimienta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiComandas;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripButton tsbtnUsuarios;
        private System.Windows.Forms.ToolStripButton tsbtnCrearMenu;
        private System.Windows.Forms.ToolStripButton tsbtnComandas;
        private System.Windows.Forms.ToolStripButton tsbtnConfig;
        private System.Windows.Forms.ToolStripLabel toolStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}