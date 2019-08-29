using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
    {
    public partial class frmPrincipal : Form
        {

        private static serializarDatos serializar = new serializarDatos();
        private static mesero meseroActual = serializar.LeerMeseroLogueado();

        private frmCrearMenu frmfrmMenu = null;
        private frmComandas frmfrmComandas = null;
        private frmAddUsuarios frmfrmUsuarios = null;
        private frmConfiguracion frmfrmConfiguracion = null;

        public frmPrincipal()
            {
            InitializeComponent();

            tsbtnUsuarios.Click += new EventHandler(VerificarAdminBotones);
            tsbtnCrearMenu.Click += new EventHandler(VerificarAdminBotones);
            tsbtnComandas.Click += new EventHandler(VerificarAdminBotones);
            tsbtnConfig.Click += new EventHandler(VerificarAdminBotones);

            tsmiUsuarios.Click += new EventHandler(VerificarAdminBotonesMenu);
            tsmiMenu.Click += new EventHandler(VerificarAdminBotonesMenu);
            tsmiComandas.Click += new EventHandler(VerificarAdminBotonesMenu);
            tsmiConfig.Click += new EventHandler(VerificarAdminBotonesMenu);

            DateTime hora = new DateTime();
            hora = DateTime.Now;
            toolStripStatusLabel1.Text = "Fecha y hora de entrada: " + hora.ToString("dd/MMMM/yyyy hh:mm:tt");

            if (meseroActual.Admin)
                {
                toolStripStatusLabel2.Text = "  ---  Modo administrador";
                }
            else
                {
                toolStripStatusLabel2.Text = "  ---  Mesero/a: " + meseroActual.Nombre;
                }
            }

        private void VerificarAdminBotonesMenu(object sender, EventArgs e)
            {
            if (tsmiComandas.Equals((ToolStripMenuItem)sender))
                {   //Abre COMANDAS
                ActivarComandas();
                }
            else //Las otras requieren verificaci'n de admin
                {
                if (meseroActual.Admin == false)
                    {
                    MessageBox.Show("Solo el administrador tiene acceso a esta opción");
                    }
                else
                    {
                    if (tsmiUsuarios.Equals((ToolStripMenuItem)sender))
                        {   //Abre Abre USUARIOS
                        ActivarUsuario();
                        }
                    else if (tsmiMenu.Equals((ToolStripMenuItem)sender))
                        {   //Abre MENU
                        ActivarMenu();
                        }
                    else if (tsmiConfig.Equals((ToolStripMenuItem)sender))
                        {   //Abre configuracion
                        ActivarConfiguracion();
                        }
                    }
                }

            }
        private void VerificarAdminBotones(object sender, EventArgs e)
            {
            if (tsbtnComandas.Equals((ToolStripButton)sender))
                {   //Abre COMANDAS
                ActivarComandas();
                }
            else //Las otras requieren verificaci'n de admin
                {
                if (meseroActual.Admin == false)
                    {
                    MessageBox.Show("Solo el administrador tiene acceso a esta opción");
                    }
                else
                    {
                    if (tsbtnUsuarios.Equals((ToolStripButton)sender))
                        {   //Abre Abre USUARIOS
                        ActivarUsuario();
                        }
                    else if (tsbtnCrearMenu.Equals((ToolStripButton)sender))
                        {   //Abre MENU
                        ActivarMenu();
                        }
                    else if (tsbtnConfig.Equals((ToolStripButton)sender))
                        {   //Abre configuracion
                        ActivarConfiguracion();
                        }
                    }
                }
            }
        private void ActivarComandas()
            {
            desmarcarBotones();
            tsbtnComandas.BackColor = Color.LightSkyBlue;
            tsmiComandas.BackColor = Color.LightSkyBlue;
            if (frmfrmComandas == null)
                {
                frmfrmComandas = new frmComandas();
                frmfrmComandas.MdiParent = this;
                frmfrmComandas.Dock = DockStyle.Fill; //Para que cubra toda la pantalla
                frmfrmComandas.FormClosed += new FormClosedEventHandler(closeForm);
                frmfrmComandas.Show();
                }
            else
                {
                frmfrmComandas.Activate();
                }
            }
        private void ActivarUsuario()
            {
            desmarcarBotones();
            tsbtnUsuarios.BackColor = Color.LightSkyBlue;
            tsmiUsuarios.BackColor = Color.LightSkyBlue;
            if (frmfrmUsuarios == null)
                {
                frmfrmUsuarios = new frmAddUsuarios();
                frmfrmUsuarios.MdiParent = this;
                frmfrmUsuarios.Dock = DockStyle.Fill; //Para que cubra toda la pantalla
                frmfrmUsuarios.FormClosed += new FormClosedEventHandler(closeForm);
                frmfrmUsuarios.Show();
                }
            else
                {
                frmfrmUsuarios.Activate();
                }
            }
        private void ActivarMenu()
            {
            desmarcarBotones();
            tsbtnCrearMenu.BackColor = Color.LightSkyBlue;
            tsmiMenu.BackColor = Color.LightSkyBlue;
            if (frmfrmMenu == null)
                {
                frmfrmMenu = new frmCrearMenu();
                frmfrmMenu.MdiParent = this;
                frmfrmMenu.Dock = DockStyle.Fill;
                frmfrmMenu.FormClosed += new FormClosedEventHandler(closeForm);
                frmfrmMenu.Show();
                }
            else
                {
                frmfrmMenu.Activate();
                }
            }
        private void ActivarConfiguracion()
            {
            desmarcarBotones();
            tsbtnConfig.BackColor = Color.LightSkyBlue;
            tsmiConfig.BackColor = Color.LightSkyBlue;
            if (frmfrmConfiguracion == null)
                {
                frmfrmConfiguracion = new frmConfiguracion();
                frmfrmConfiguracion.MdiParent = this;
                frmfrmConfiguracion.Dock = DockStyle.Fill; //Para que cubra toda la pantalla
                frmfrmConfiguracion.FormClosed += new FormClosedEventHandler(closeForm);
                frmfrmConfiguracion.Show();
                }
            else
                {
                frmfrmConfiguracion.Activate();
                }
            }
        private void desmarcarBotones()
            {
            tsmiComandas.BackColor = Color.White;
            tsmiUsuarios.BackColor = Color.White;
            tsmiMenu.BackColor = Color.White;
            tsmiConfig.BackColor = Color.White;

            tsbtnUsuarios.BackColor = Color.White;
            tsbtnCrearMenu.BackColor = Color.White;
            tsbtnComandas.BackColor = Color.White;
            tsbtnConfig.BackColor = Color.White;
            }
        private void closeForm(object sender, FormClosedEventArgs e)
            {
            try
                {
                if (frmfrmComandas.Equals((frmComandas)sender))
                    {
                    frmfrmComandas = null;
                    }
                }
            catch { }
            try
                {
                if (frmfrmMenu.Equals((frmCrearMenu)sender))
                    {
                    frmfrmMenu = null;
                    }
                }
            catch { }
            try
                {
                if (frmfrmConfiguracion.Equals((frmConfiguracion)sender))
                    {
                    frmfrmConfiguracion = null;
                    }
                }
            catch { }
            try
                {
                if (frmfrmUsuarios.Equals((frmAddUsuarios)sender))
                    {
                    frmfrmUsuarios = null;
                    }
                }
            catch { }
            }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
            {
            this.Hide();
            this.Close();
            }
        }
    }
