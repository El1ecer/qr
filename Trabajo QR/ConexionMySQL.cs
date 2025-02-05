using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Trabajo_QR
{
    internal class ConexionMySQL
    {
        public MySqlConnection MySql = new MySqlConnection("server=localhost;user=root;password=root;database=bodega;port=3306");

        public void Insertar(string sql)
        {
            MySql.Open();
            var comando = new MySqlCommand(sql, MySql);
            //usamos 2 el que devuelve datos y el que no lo hace, execute non query
            comando.ExecuteNonQuery();
            MySql.Close();

        }

        public void AbrirConexion()
        {
            MySql.Open();
        }

        public void CerrarConexion()
        {
            MySql.Close();
        }

        public MySqlDataReader Select(string sql)
        {
            //MySql.Open();
            //Reader para leer los datos y almacenarlos en otra variable
            var comando = new MySqlCommand(sql, MySql);
            var data = comando.ExecuteReader();
            //MySql.Close();
            return data;
            //se debe de retornar la variable data
        }
        public MySqlDataReader Buscar(string sql)
        {
            var comando = new MySqlCommand(sql, MySql);
            var data1 = comando.ExecuteReader();
            return data1;
        }
        public void Modificar(string sql)
        {
            MySql.Open();
            var comando = new MySqlCommand( sql, MySql);
            comando.ExecuteNonQuery();
            MySql.Close();
        }
    }
}
