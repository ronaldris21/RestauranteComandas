using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmConfiguracion : Form
    {
        private static serializarDatos serializar = new serializarDatos();
        private static Dictionary<string, mesero> dMeseros = serializar.LeerMeseros();
        private static Dictionary<string, comanda> dComandas = serializar.LeerComandas();
        private static configuracion confi;
        public frmConfiguracion()
        {
            InitializeComponent();
            confi = serializar.LeerConfiguracion();
            nudPorcentaje.Value = Convert.ToDecimal(confi.PorcentajePropina);
            nudMesas.Value = Convert.ToDecimal(confi.CantMesas);
            pnlConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
                if (dMeseros["Admin"].Password == txtContraseña.Text && "Admin" == txtUsuario.Text)
                {
                    confi.CantMesas = Convert.ToInt16(nudMesas.Value);
                    confi.PorcentajePropina = Convert.ToDouble(nudPorcentaje.Value);
                    txtContraseña.Clear();
                    txtUsuario.Clear();
                    MessageBox.Show("Configuración modificada.");
                    dComandas.Clear();
                    for (int i = 0; i < confi.CantMesas; i++)
                    {
                        comanda newComan = new comanda(i.ToString());
                        dComandas.Add(newComan.NumMesa, newComan);
                    }
                    serializar.GuardarComandas(dComandas);
                    serializar.GuardarConfiguracion(confi);

                }
                else
                {
                    MessageBox.Show("Credenciales de administrador incorrectas.");
                }
            }
        }
        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            pnlConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
        }
    }
}
