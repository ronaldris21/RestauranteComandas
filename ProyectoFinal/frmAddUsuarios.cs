using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal
    {
    public partial class frmAddUsuarios : Form
        {
        private static Dictionary<string, mesero> dMeseros;
        private static serializarDatos serializar = new serializarDatos();

        public frmAddUsuarios()
            {
            InitializeComponent();
            dMeseros = serializar.LeerMeseros();
            panel1.Anchor = System.Windows.Forms.AnchorStyles.None;//Hace responsive
            }

        private void btnSalir_Click(object sender, EventArgs e)
            {
            Close();
            }
        private static void ActualizarGrid(ref DataGridView grid)
            {
            if (dMeseros.Count >= 0)
                {
                grid.Rows.Clear();
                foreach (KeyValuePair<string, mesero> user in dMeseros)
                    {
                    if (user.Key != "Admin")
                        {
                        grid.Rows.Add(user.Value.Nombre, user.Value.Username, user.Value.Password);
                        }
                    }
                grid.ClearSelection();
                }
            }
        private void btnAgregar_Click(object sender, EventArgs e)
            {
            bool completado = true;
            if (txtNombre.Text == String.Empty)
                {
                errMensaje.SetError(txtNombre, "Ingrese el Nombre.");
                completado = false;
                }
            else
                {
                errMensaje.SetError(txtNombre, null);
                }
            if (txtUsuario.Text == String.Empty)
                {
                errMensaje.SetError(txtUsuario, "Ingrese el Usuario.");
                completado = false;
                }
            else
                {
                errMensaje.SetError(txtUsuario, null);
                }
            if (txtContra.Text == String.Empty)
                {
                errMensaje.SetError(txtContra, "Ingrese la Contraseña.");
                completado = false;
                }
            else
                {
                errMensaje.SetError(txtContra, null);
                }
            if (completado && !dMeseros.ContainsKey(txtUsuario.Text))
                {
                string nombre = txtNombre.Text;
                string usuario = txtUsuario.Text;
                string contra = txtContra.Text;

                mesero Usuario = new mesero(nombre, usuario, contra);
                dMeseros.Add(Usuario.Username, Usuario);
                serializar.GuardarMeseros(dMeseros);

                txtNombre.Clear();
                txtUsuario.Clear();
                txtContra.Clear();
                MessageBox.Show(Usuario.Nombre + " ha sido agregado.");
                ActualizarGrid(ref dgvUsuarios);
                }
            else
                {
                MessageBox.Show("Ya existe ese usuario, elija otro");
                }
            }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if (e.ColumnIndex == dgvUsuarios.Columns[3].Index && e.RowIndex >= 0)
                {
                string nombre = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar al usuario: " + nombre + "?", "Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                    {
                    string usua = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                    dMeseros.Remove(usua);
                    serializar.GuardarMeseros(dMeseros);
                    ActualizarGrid(ref dgvUsuarios);
                    }
                }
            }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (char.IsLetter(e.KeyChar))
                {
                e.Handled = false;
                }
            else if (char.IsControl(e.KeyChar))
                {
                e.Handled = false;
                }
            else if (char.IsSeparator(e.KeyChar))
                {
                e.Handled = false;
                }
            else
                {
                e.Handled = true;
                }
            }
        private void AddUsuarios_Load(object sender, EventArgs e)
            {
            dMeseros = serializar.LeerMeseros();
            ActualizarGrid(ref dgvUsuarios);
            }
        }
    }
