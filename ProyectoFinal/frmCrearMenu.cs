using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmCrearMenu : Form
    {

        private static Dictionary<string, menu> dMenu;
        private static serializarDatos serializar = new serializarDatos();

        public frmCrearMenu()
        {
            InitializeComponent();
            AutoScroll = true;
            dMenu = serializar.LeerMenu();
            panel.Anchor = AnchorStyles.None;
        }
        private static void ActualizarGrid(ref DataGridView grid)
        {
            if (dMenu.Count >= 0)
            {
                grid.Rows.Clear();
                foreach (KeyValuePair<string, menu> men in dMenu)
                {
                    grid.Rows.Add(men.Value.Tipo, men.Value.Descrip, men.Value.Precio);
                }
                grid.ClearSelection();
            }
        }
        private void CrearMenu_Load(object sender, EventArgs e)
        {
            dMenu = serializar.LeerMenu();
            ActualizarGrid(ref dgvMenu);
        }
        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMenu.Columns[3].Index && e.RowIndex >= 0)
            {
                string descripcion = dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString();
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar: " + descripcion + "?", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    dMenu.Remove(descripcion);
                    serializar.GuardarMenu(dMenu);
                    ActualizarGrid(ref dgvMenu);
                }
            }
        }
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool completado = true;
            if (cboTipo.Text == String.Empty)
            {
                errMensaje.SetError(cboTipo, "Seleccione el tipo.");
                completado = false;
            }
            else
                errMensaje.SetError(cboTipo, null);
            if (txtDescripcion.Text == String.Empty)
            {
                errMensaje.SetError(txtDescripcion, "Escriba la descripción.");
                completado = false;
            }
            else
            {
                errMensaje.SetError(txtDescripcion, null);
            }
            if (completado)
            {
                string tipo = cboTipo.Text;
                string descrip = txtDescripcion.Text;
                string precio = Convert.ToString(nudPrecio.Value);
                if (!dMenu.ContainsKey(descrip))
                {
                    menu men = new menu(tipo, descrip, precio);
                    dMenu.Add(men.Descrip, men);
                    serializar.GuardarMenu(dMenu);

                    cboTipo.SelectedIndex = -1;
                    txtDescripcion.Clear();
                    nudPrecio.Value = 1;
                    MessageBox.Show("Los datos fueron almacenados.");
                    ActualizarGrid(ref dgvMenu);
                }
                else
                {
                    MessageBox.Show("Ya existe.");
                }
            }
        }
    }
}