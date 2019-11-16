using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class RestaurantePadre : Form
    {

        private static Dictionary<string, mesero> dMeseros = new Dictionary<string, mesero>();
        private static serializarDatos serializar = new serializarDatos();

        public RestaurantePadre()
        {
            InitializeComponent();
            dMeseros = serializar.LeerMeseros();
            //Agregar al admin manualmente
            //Descomentar la siguientes 2 lineas la primera ejecución
            dMeseros.Add("Admin", new mesero("Administrador", "Admin", "2525", true));
            serializar.GuardarMeseros(dMeseros);

            ////Mesero manualmente
            //dMeseros.Add("2018HA", new mesero("Gabriela Hernández", "2018HA", "1234"));
            //serializar.GuardarMeseros(dMeseros);
            Anchor = AnchorStyles.None;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            bool completado = true;
            if (txtUsuario.Text == string.Empty)
            {
                errMensaje.SetError(txtUsuario, "Ingrese un usuario");
                completado = false;
            }
            else
            {
                errMensaje.SetError(txtUsuario, null);
            }
            if (txtContraseña.Text == string.Empty)
            {
                errMensaje.SetError(txtContraseña, "Ingrese una contraseña");
                completado = false;
            }
            else
            {
                errMensaje.SetError(txtContraseña, null);
            }
            if (completado)
            {
                if (rdoAdmin.Checked)//Mandar booleano al MDI principal indicando que es admin
                {
                    if (dMeseros.ContainsKey(txtUsuario.Text))
                    {
                        mesero Admin = dMeseros["Admin"];
                        if (Admin.Password == txtContraseña.Text && Admin.Admin == true)//Ingresar como admin
                        {
                            serializar.GuardarMeseroLogueado(Admin);
                            MessageBox.Show("Modo Administrador activo");
                            frmPrincipal frm = new frmPrincipal();
                            this.Hide();
                            frm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            if (Admin.Admin == false)
                            {
                                MessageBox.Show("Usted no es un Administrador.");
                            }
                            else
                            {
                                MessageBox.Show("Contraseña no válida.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Administrador no válido.");
                    }
                }
                else
                {
                    if (dMeseros.ContainsKey(txtUsuario.Text))
                    {
                        mesero mese = dMeseros[txtUsuario.Text];
                        if (mese.Password == txtContraseña.Text && mese.Admin == false)//Ingresar como mesero
                        {
                            serializar.GuardarMeseroLogueado(mese);
                            MessageBox.Show("Bienvenido, mesero " + mese.Nombre);
                            this.Hide();
                            frmPrincipal frm = new frmPrincipal();
                            frm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña no válida.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mesero no válido.");
                    }
                }
            }
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
