using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Libros
    {
        private CD_Libros objetoCD = new CD_Libros();

        public DataTable MostrarProd() {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPRod ( string nombre,string auto,string precio, string stock){

            objetoCD.Insertar(nombre,auto,Convert.ToDouble(precio),Convert.ToInt32(stock));
    }

        public void EditarProd(string nombre, string auto,  string precio, string stock,string id)
        {
            objetoCD.Editar(nombre, auto, Convert.ToDouble(precio), Convert.ToInt32(stock),Convert.ToInt32(id));
        }

        public void EliminarPRod(string id) {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
