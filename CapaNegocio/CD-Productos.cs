using CapasDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CD_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        private DataTable Mostrar()
        {
            throw new NotImplementedException();
        }

        public void InsertarPRod(string nombre, string desc, string
        marca, string precio, string stock)
        {
            objetoCD.Insertar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        private void Insertar(string nombre, string desc, string marca, double v1, int v2)
        {
            throw new NotImplementedException();
        }

        public void EditarProd(string nombre, string desc, string marca,
        string precio, string stock, string id)
        {
            objetoCD.Editar(nombre, desc, marca,
            Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }

        private void Editar(string nombre, string desc, string marca, double v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        public void EliminarPRod(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }

        private void Eliminar(int v)
        {
            throw new NotImplementedException();
        }
    }
}
