using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ProyectoFinal
    {
    [Serializable]
    class serializarDatos
        {
        public void GuardarMeseros(Dictionary<string, mesero> dMesero)
            {
            try
                {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fs = new FileStream("mesero.dat", FileMode.Create, FileAccess.Write);
                formatter.Serialize(fs, dMesero);
                fs.Close();
                }
            catch (Exception)
                {
                MessageBox.Show("No fue posible almacenar los datos");
                }
            }

        public Dictionary<string, mesero> LeerMeseros()
            {
            if (File.Exists("mesero.dat"))
                {
                try
                    {
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream fs = new FileStream("mesero.dat", FileMode.Open, FileAccess.Read);
                    Dictionary<string, mesero> dmesero = (Dictionary<string, mesero>)formatter.Deserialize(fs);
                    fs.Close();
                    return dmesero;
                    }
                catch
                    {
                    MessageBox.Show("No es posible leer el archivo Mesero");
                    return new Dictionary<string, mesero>();
                    }
                }
            else
                {
                return new Dictionary<string, mesero>();
                }
            }

        public void GuardarComandas(Dictionary<string, comanda> dComandas)
            {
            try
                {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fs = new FileStream("comandas.dat", FileMode.Create, FileAccess.Write);
                formatter.Serialize(fs, dComandas);
                fs.Close();
                }
            catch
                {
                MessageBox.Show("No fue posible almacenar los datos");
                }
            }

        public Dictionary<string, comanda> LeerComandas()
            {
            if (File.Exists("comandas.dat"))
                {
                try
                    {
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream fs = new FileStream("comandas.dat", FileMode.Open, FileAccess.Read);
                    Dictionary<string, comanda> dComandas = (Dictionary<string, comanda>)formatter.Deserialize(fs);
                    fs.Close();
                    return dComandas;
                    }
                catch
                    {
                    MessageBox.Show("No es posible leer el archivo");
                    return new Dictionary<string, comanda>();
                    }
                }
            else
                {
                return new Dictionary<string, comanda>();
                }
            }

        public void GuardarMenu(Dictionary<string, menu> lMenu)
            {
            try
                {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fs = new FileStream("menu.dat", FileMode.Create, FileAccess.Write);
                formatter.Serialize(fs, lMenu);
                fs.Close();
                }
            catch
                {
                MessageBox.Show("No fue posible almacenar los datos");
                }
            }

        public Dictionary<string, menu> LeerMenu()
            {
            if (File.Exists("menu.dat"))
                {
                try
                    {
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream fs = new FileStream("menu.dat", FileMode.Open, FileAccess.Read);
                    Dictionary<string, menu> dMenu = (Dictionary<string, menu>)formatter.Deserialize(fs);
                    fs.Close();
                    return dMenu;
                    }
                catch
                    {
                    MessageBox.Show("No es posible leer el archivo");
                    return new Dictionary<string, menu>();
                    }
                }
            else
                {
                return new Dictionary<string, menu>();
                }
            }

        public void GuardarMeseroLogueado(mesero mese)
            {
            try
                {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fs = new FileStream("meseroLogeado.dat", FileMode.Create, FileAccess.Write);
                formatter.Serialize(fs, mese);
                fs.Close();
                }
            catch
                {
                MessageBox.Show("No fue posible almacenar los datos");
                }
            }

        public mesero LeerMeseroLogueado()
            {
            if (File.Exists("meseroLogeado.dat"))
                {
                try
                    {
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream fs = new FileStream("meseroLogeado.dat", FileMode.Open, FileAccess.Read);
                    mesero mese = (mesero)formatter.Deserialize(fs);
                    fs.Close();
                    return mese;
                    }
                catch (Exception)
                    {
                    MessageBox.Show("No es posible leer el archivo");
                    return new mesero();
                    }
                }
            else
                {
                return new mesero();
                }
            }

        public void GuardarConfiguracion(configuracion confi)
            {
            try
                {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fs = new FileStream("configuracion.dat", FileMode.Create, FileAccess.Write);
                formatter.Serialize(fs, confi);
                fs.Close();
                }
            catch
                {
                MessageBox.Show("No fue posible almacenar los datos");
                }
            }

        public configuracion LeerConfiguracion()
            {
            if (File.Exists("configuracion.dat"))
                {
                try
                    {
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream fs = new FileStream("configuracion.dat", FileMode.Open, FileAccess.Read);
                    configuracion confi = (configuracion)formatter.Deserialize(fs);
                    fs.Close();
                    return confi;
                    }
                catch
                    {
                    MessageBox.Show("No es posible leer el archivo");
                    return new configuracion();
                    }
                }
            else
                {
                return new configuracion();
                }
            }
        }
    }