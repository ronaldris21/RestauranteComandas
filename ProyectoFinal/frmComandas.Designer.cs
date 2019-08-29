namespace ProyectoFinal
{
    partial class frmComandas
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
            this.tabComandas = new System.Windows.Forms.TabControl();
            this.tpMesas = new System.Windows.Forms.TabPage();
            this.flpComandas = new System.Windows.Forms.FlowLayoutPanel();
            this.tpPedidos = new System.Windows.Forms.TabPage();
            this.pnlPedidos = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMesa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            this.dgvDisponible = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnAgregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPlatos = new System.Windows.Forms.ComboBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabComandas.SuspendLayout();
            this.tpMesas.SuspendLayout();
            this.tpPedidos.SuspendLayout();
            this.pnlPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // tabComandas
            // 
            this.tabComandas.Controls.Add(this.tpMesas);
            this.tabComandas.Controls.Add(this.tpPedidos);
            this.tabComandas.Location = new System.Drawing.Point(12, 12);
            this.tabComandas.Name = "tabComandas";
            this.tabComandas.SelectedIndex = 0;
            this.tabComandas.Size = new System.Drawing.Size(975, 565);
            this.tabComandas.TabIndex = 0;
            // 
            // tpMesas
            // 
            this.tpMesas.Controls.Add(this.flpComandas);
            this.tpMesas.Location = new System.Drawing.Point(4, 22);
            this.tpMesas.Name = "tpMesas";
            this.tpMesas.Padding = new System.Windows.Forms.Padding(3);
            this.tpMesas.Size = new System.Drawing.Size(967, 539);
            this.tpMesas.TabIndex = 0;
            this.tpMesas.Text = "Mesas";
            this.tpMesas.UseVisualStyleBackColor = true;
            this.tpMesas.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // flpComandas
            // 
            this.flpComandas.AutoScroll = true;
            this.flpComandas.BackColor = System.Drawing.Color.Gainsboro;
            this.flpComandas.Location = new System.Drawing.Point(6, 6);
            this.flpComandas.Name = "flpComandas";
            this.flpComandas.Size = new System.Drawing.Size(955, 533);
            this.flpComandas.TabIndex = 0;
            // 
            // tpPedidos
            // 
            this.tpPedidos.AutoScroll = true;
            this.tpPedidos.Controls.Add(this.pnlPedidos);
            this.tpPedidos.Location = new System.Drawing.Point(4, 22);
            this.tpPedidos.Name = "tpPedidos";
            this.tpPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tpPedidos.Size = new System.Drawing.Size(967, 539);
            this.tpPedidos.TabIndex = 1;
            this.tpPedidos.Text = "Pedidos";
            this.tpPedidos.UseVisualStyleBackColor = true;
            // 
            // pnlPedidos
            // 
            this.pnlPedidos.Controls.Add(this.btnCancelar);
            this.pnlPedidos.Controls.Add(this.lblMesa);
            this.pnlPedidos.Controls.Add(this.label1);
            this.pnlPedidos.Controls.Add(this.nudCant);
            this.pnlPedidos.Controls.Add(this.dgvDisponible);
            this.pnlPedidos.Controls.Add(this.label3);
            this.pnlPedidos.Controls.Add(this.cboPlatos);
            this.pnlPedidos.Controls.Add(this.btnPagar);
            this.pnlPedidos.Controls.Add(this.label2);
            this.pnlPedidos.Controls.Add(this.lblTotal);
            this.pnlPedidos.Controls.Add(this.btnBuscar);
            this.pnlPedidos.Controls.Add(this.label5);
            this.pnlPedidos.Controls.Add(this.btnGuardar);
            this.pnlPedidos.Controls.Add(this.dgvPedido);
            this.pnlPedidos.Location = new System.Drawing.Point(197, 23);
            this.pnlPedidos.Name = "pnlPedidos";
            this.pnlPedidos.Size = new System.Drawing.Size(572, 493);
            this.pnlPedidos.TabIndex = 24;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(155, 467);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar pedido";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(337, 23);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(39, 13);
            this.lblMesa.TabIndex = 26;
            this.lblMesa.Text = "Mesa: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Seleccione la cantidad a comprar";
            // 
            // nudCant
            // 
            this.nudCant.Location = new System.Drawing.Point(322, 239);
            this.nudCant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCant.Name = "nudCant";
            this.nudCant.Size = new System.Drawing.Size(54, 20);
            this.nudCant.TabIndex = 24;
            // 
            // dgvDisponible
            // 
            this.dgvDisponible.AllowUserToAddRows = false;
            this.dgvDisponible.AllowUserToDeleteRows = false;
            this.dgvDisponible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnTipo,
            this.dataGridViewTextBoxColumnDescripcion,
            this.dataGridViewTextBoxColumnPrecio,
            this.dataGridViewTextBoxColumnAgregar});
            this.dgvDisponible.Location = new System.Drawing.Point(26, 83);
            this.dgvDisponible.MultiSelect = false;
            this.dgvDisponible.Name = "dgvDisponible";
            this.dgvDisponible.ReadOnly = true;
            this.dgvDisponible.RowHeadersVisible = false;
            this.dgvDisponible.Size = new System.Drawing.Size(508, 150);
            this.dgvDisponible.TabIndex = 23;
            this.dgvDisponible.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisponible_CellContentClick);
            // 
            // dataGridViewTextBoxColumnTipo
            // 
            this.dataGridViewTextBoxColumnTipo.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumnTipo.Name = "dataGridViewTextBoxColumnTipo";
            this.dataGridViewTextBoxColumnTipo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnDescripcion
            // 
            this.dataGridViewTextBoxColumnDescripcion.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumnDescripcion.Name = "dataGridViewTextBoxColumnDescripcion";
            this.dataGridViewTextBoxColumnDescripcion.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnPrecio
            // 
            this.dataGridViewTextBoxColumnPrecio.HeaderText = "Precio";
            this.dataGridViewTextBoxColumnPrecio.Name = "dataGridViewTextBoxColumnPrecio";
            this.dataGridViewTextBoxColumnPrecio.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnAgregar
            // 
            this.dataGridViewTextBoxColumnAgregar.HeaderText = "Agregar";
            this.dataGridViewTextBoxColumnAgregar.Name = "dataGridViewTextBoxColumnAgregar";
            this.dataGridViewTextBoxColumnAgregar.ReadOnly = true;
            this.dataGridViewTextBoxColumnAgregar.Text = "Agregar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pedido";
            // 
            // cboPlatos
            // 
            this.cboPlatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlatos.FormattingEnabled = true;
            this.cboPlatos.Items.AddRange(new object[] {
            "Entradas",
            "Platos",
            "Bebidas",
            "Postres"});
            this.cboPlatos.Location = new System.Drawing.Point(71, 16);
            this.cboPlatos.Name = "cboPlatos";
            this.cboPlatos.Size = new System.Drawing.Size(121, 21);
            this.cboPlatos.TabIndex = 12;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(459, 467);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 21;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(170, 441);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(207, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Menu Disponible";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(26, 467);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 23);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar pedido";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvPedido.Location = new System.Drawing.Point(26, 284);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.Size = new System.Drawing.Size(508, 150);
            this.dgvPedido.TabIndex = 17;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tipo";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Descripcion";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Precio";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Cantidad";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Sub total";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Eliminar";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // frmComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 577);
            this.Controls.Add(this.tabComandas);
            this.Name = "frmComandas";
            this.Text = "Administración de las comandas";
            this.Activated += new System.EventHandler(this.frmComandasPadre_Activated);
            this.tabComandas.ResumeLayout(false);
            this.tpMesas.ResumeLayout(false);
            this.tpPedidos.ResumeLayout(false);
            this.pnlPedidos.ResumeLayout(false);
            this.pnlPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabComandas;
        private System.Windows.Forms.TabPage tpMesas;
        private System.Windows.Forms.TabPage tpPedidos;
        private System.Windows.Forms.FlowLayoutPanel flpComandas;
        private System.Windows.Forms.Panel pnlPedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPlatos;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewButtonColumn Column12;
        private System.Windows.Forms.DataGridView dgvDisponible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnPrecio;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumnAgregar;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Button btnCancelar;
    }
}