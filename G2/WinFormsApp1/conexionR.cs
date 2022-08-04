using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioClinico
{
    class conexionR
    {
        public static MySqlConnection conexion()
        {
            string servidor = "b3jnhmjenwsvvibvoljt-mysql.services.clever-cloud.com";
            string bd = "b3jnhmjenwsvvibvoljt";
            string usuario = "uoek6asd7jjostvb";
            string password = "FdMipYrOneL8uzBTDoVB";

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor +
                "; User Id=" + usuario + "; Password=" + password + "";
            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }

        }
    }
}
