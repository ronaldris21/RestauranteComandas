using System;

namespace ProyectoFinal
{
    [Serializable]
    class menu
    {
        private string tipo;
        private string descrip;
        private string precio;
        private string cant;

        public menu(string tipo, string descrip, string precio)
        {
            Tipo = tipo;
            Descrip = descrip;
            Precio = precio;
            cant = "0";
        }

        public menu(string tipo, string descrip, string precio, string cant)
        {
            this.Tipo = tipo;
            this.Descrip = descrip;
            this.Precio = precio;
            this.cant = cant;
        }

        public string Tipo { get { return tipo; } set { tipo = value; } }
        public string Descrip { get { return descrip; } set { descrip = value; } }
        public string Precio { get { return precio; } set { precio = value; } }
        public string Cant { get { return cant; } set { cant = value; } }
    }
}