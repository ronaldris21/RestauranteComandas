using System;

namespace ProyectoFinal
{
    [Serializable]
    class mesero
    {
        private string nombre;
        private string username;
        private string password;
        private bool admin;
        public mesero() { }
        public mesero(string nombre, string usuario, string pass)
        {
            Nombre = nombre;
            Username = usuario;
            Password = pass;
            admin = false;
        }

        public mesero(string nombre, string usuario, string pass, bool admin)
        {
            Nombre = nombre;
            Username = usuario;
            Password = pass;
            admin = true;
        }

        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Username { get { return this.username; } set { this.username = value; } }
        public string Password { get { return this.password; } set { this.password = value; } }
        public bool Admin { get { return this.admin; } set { this.admin = value; } }
    }
}