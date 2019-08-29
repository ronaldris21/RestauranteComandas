using System;
using System.Collections.Generic;

namespace ProyectoFinal
    {
    [Serializable]
    class comanda
        {
        private string numMesa;
        private mesero meseroComanda;
        private DateTime fechaHora;
        private List<menu> lMenu;
        private bool disponible;

        public comanda(string numMesa)
            {
            this.numMesa = numMesa;
            this.disponible = true;
            lMenu = new List<menu>();
            }

        public comanda(string numMesa, mesero meseroComanda, List<menu> lMenu)
            {
            this.numMesa = numMesa;
            this.meseroComanda = meseroComanda;
            this.lMenu = lMenu;
            this.fechaHora = DateTime.Now;
            this.disponible = false;
            }

        public string getTotalPagar(double propina)
            {
            double total = 0;
            foreach (menu item in lMenu)
                {
                total += Convert.ToDouble(item.Cant) * Convert.ToDouble(item.Precio);
                }
            total = total * (1 + propina / 100 + 0.13);
            return "$ " + Convert.ToString(total);
            }
        public string getSubtotal(double propina)
            {
            double total = 0;
            foreach (menu item in lMenu)
                {
                total += Convert.ToDouble(item.Cant) * Convert.ToDouble(item.Precio);
                }
            return "$ " + Convert.ToString(total);
            }

        public void GuardarPedido(mesero meseroComanda, List<menu> lMenu)
            {
            this.meseroComanda = meseroComanda;
            this.fechaHora = DateTime.Now;
            this.lMenu = lMenu;
            disponible = false;
            }

        public void Pagar()
            {
            this.meseroComanda = null;
            this.lMenu.Clear();
            disponible = true;
            }

        public string NumMesa { get { return numMesa; } set { numMesa = value; } }
        public mesero MeseroComanda { get { return meseroComanda; } set { meseroComanda = value; } }
        public List<menu> LMenu { get { return this.lMenu; } set { this.lMenu = value; } }
        public bool Disponible { get { return this.disponible; } set { this.disponible = value; } }
        public string FechaHora
            {
            get
                {
                String fecha = fechaHora.ToString("dd/MMMM/yyyy") + " - " + fechaHora.ToString("hh:mm:tt");
                return fecha;
                }
            set { numMesa = value; }
            }
        }
    }