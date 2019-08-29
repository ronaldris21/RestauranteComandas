using System;

namespace ProyectoFinal
    {
    [Serializable]
    class configuracion
        {
        private int cantMesas;
        private double porcentajePropina;

        public configuracion()
            {
            cantMesas = 10;
            porcentajePropina = 10;
            }

        public configuracion(int cantMesas, double porcentajePropina)
            {
            this.cantMesas = cantMesas;
            this.porcentajePropina = porcentajePropina;
            }

        public int CantMesas { get { return cantMesas; } set { cantMesas = value; } }
        public double PorcentajePropina { get { return porcentajePropina; } set { porcentajePropina = value; } }
        }
    }
