using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal
    {
    public partial class frmComandas : Form
        {
        private static serializarDatos serializar = new serializarDatos();
        private static configuracion confi = serializar.LeerConfiguracion();
        private static Dictionary<string, comanda> dComanda = serializar.LeerComandas();
        private static Dictionary<string, menu> dMenu = serializar.LeerMenu();
        private static comanda mesaSeleccionada = null;
        private static mesero meseroActual = serializar.LeerMeseroLogueado();
        private static List<menu> lmenuActual = new List<menu>();

        public frmComandas()
            {
            InitializeComponent();
            tabComandas.Anchor = AnchorStyles.None;
            flpComandas.Anchor = AnchorStyles.None;
            pnlPedidos.Anchor = AnchorStyles.None;
            tabComandas.Enter += new EventHandler(verificarMesaSelccionada);
            }
        private void verificarMesaSelccionada(object sender, EventArgs e)
            {
            if (mesaSeleccionada == null)
                {
                MessageBox.Show("Debe seleccionar una mesa primero.");
                tabComandas.SelectedTab = tpMesas;
                }
            }
        private void tabPage1_Click(object sender, EventArgs e)
            {
            }
        private void frmComandasPadre_Activated(object sender, EventArgs e)
            {
            inicializar();
            }
        private void inicializar()
            {
            //Actuallizar variables
            confi = serializar.LeerConfiguracion();
            dComanda = serializar.LeerComandas();
            dMenu = serializar.LeerMenu();
            tabComandas.SelectedTab = tpMesas;

            mesaSeleccionada = null;
            lmenuActual.Clear();
            flpComandas.Controls.Clear();

            for (int i = 0; i < confi.CantMesas; i++)
                {
                Button btnMesa = new Button();
                btnMesa.Name = i.ToString();
                btnMesa.Width = 80;
                btnMesa.Height = 80;
                btnMesa.Click += new EventHandler(clickMesa);
                ToolTip tip = new ToolTip(); //Mostrar el nombre al poner el mouse sobre el botón

                comanda coman = dComanda[i.ToString()];
                if (coman.Disponible)
                    {
                    btnMesa.BackgroundImage = ProyectoFinal.Properties.Resources.Solo;
                    tip.SetToolTip(btnMesa, "Mesa " + (i + 1).ToString() + " Disponible");
                    }
                else
                    {
                    btnMesa.BackgroundImage = ProyectoFinal.Properties.Resources.Ocupado;
                    tip.SetToolTip(btnMesa, "Mesa " + (i + 1).ToString() + " Ocupada");

                    }
                btnMesa.BackgroundImageLayout = ImageLayout.Stretch;
                flpComandas.Controls.Add(btnMesa);
                }
            }
        private void clickMesa(object sender, EventArgs e)
            {
            Button btn = (Button)sender;
            mesaSeleccionada = dComanda[btn.Name];
            tabComandas.SelectedTab = tpPedidos;
            lmenuActual.Clear();
            lblMesa.Text = "Mesa " + (Convert.ToInt32(mesaSeleccionada.NumMesa) + 1);
            lmenuActual = dComanda[mesaSeleccionada.NumMesa].LMenu;
            ActualizarGridPedidos();
            }
        private void btnBuscar_Click(object sender, EventArgs e)
            {
            if (dMenu.Count >= 0)
                {
                dgvDisponible.Rows.Clear();
                foreach (KeyValuePair<string, menu> men in dMenu)
                    {
                    if (men.Value.Tipo == cboPlatos.Text)
                        {
                        dgvDisponible.Rows.Add(men.Value.Tipo, men.Value.Descrip, men.Value.Precio, "Agregar");
                        }
                    }
                dgvDisponible.ClearSelection();
                }
            }

        private void dgvDisponible_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if (e.ColumnIndex == dgvDisponible.Columns[3].Index && e.RowIndex >= 0)
                {
                if (nudCant.Value > 0)
                    {
                    string descripcion = dgvDisponible.Rows[e.RowIndex].Cells[1].Value.ToString();
                    menu nuevoPedido = dMenu[descripcion];
                    nuevoPedido.Cant = nudCant.Value.ToString();
                    lmenuActual.Add(nuevoPedido);
                    ActualizarGridPedidos();
                    nudCant.Value = 0;
                    }
                else
                    {
                    MessageBox.Show("Seleccione una cantidad.");
                    }
                }
            }
        private void ActualizarGridPedidos()
            {
            if (lmenuActual.Count >= 0)
                {
                dgvPedido.Rows.Clear();
                double total = 0;
                foreach (menu men in lmenuActual)
                    {
                    double subtotalDouble = Convert.ToDouble(men.Precio) * Convert.ToDouble(men.Cant);
                    total = total + subtotalDouble;
                    dgvPedido.Rows.Add(men.Tipo, men.Descrip, men.Precio, men.Cant, Convert.ToString(subtotalDouble), "Eliminar");
                    }
                dgvPedido.ClearSelection();
                total = total * (1 + (double)confi.PorcentajePropina / 100 + 0.13); //Propinas e IVA
                lblTotal.Text = string.Format("{0:c2}", total) + " ; incluye " + confi.PorcentajePropina + "% de propina y 13% de IVA";
                }
            }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if (e.ColumnIndex == dgvPedido.Columns[5].Index && e.RowIndex >= 0)
                {
                string descripcion = dgvPedido.Rows[e.RowIndex].Cells[1].Value.ToString();
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar: " + descripcion + "?", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                    {
                    string tipo = dgvPedido.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string precio = dgvPedido.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string cant = dgvPedido.Rows[e.RowIndex].Cells[3].Value.ToString();

                    foreach (menu men in lmenuActual)
                        {
                        if (men.Tipo == tipo && men.Descrip == descripcion && men.Precio == precio && men.Cant == cant)
                            {
                            lmenuActual.Remove(men);
                            ActualizarGridPedidos();
                            MessageBox.Show("Eliminado correctamente.");
                            return;
                            }
                        }
                    }
                }
            }
        private void btnGuardar_Click(object sender, EventArgs e)
            {
            if (lmenuActual.Count > 0)
                {
                dComanda[mesaSeleccionada.NumMesa].GuardarPedido(meseroActual, lmenuActual);
                serializar.GuardarComandas(dComanda);
                MessageBox.Show("Pedido guardado.");
                inicializar();
                tabComandas.SelectedTab = tpMesas;
                }
            else
                {
                MessageBox.Show("No hay nada ordenado.");
                }
            }
        private void btnPagar_Click(object sender, EventArgs e)
            {
            if (dComanda[mesaSeleccionada.NumMesa].Disponible)
                {
                MessageBox.Show("Aún no se realiza un pedido.");
                }
            else
                {
                cancelar();
                MessageBox.Show("La cuenta ha sido cancelada.");
                }
            }
        private void btnCancelar_Click(object sender, EventArgs e)
            {
            cancelar();
            }
        private void cancelar()
            {
            try
                {
                lmenuActual.Clear();
                lblTotal.Text = "Total";
                lblMesa.Text = "Mesa";
                tabComandas.SelectedTab = tpMesas;
                dComanda[mesaSeleccionada.NumMesa].Pagar();
                serializar.GuardarComandas(dComanda);
                mesaSeleccionada = null;
                inicializar();
                }
            catch
                {
                throw;
                }
            }
        }
    }