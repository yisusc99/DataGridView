using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataGridView
{
    public class Conexion
    {
        public static MySqlConnection connector()
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection("server= 127.0.0.1; database=crud ;Uid=root;Pwd=pruebapass123;");
                connection.Open();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return connection;
        }
        public static bool create(string name, double precio, int cant, string des) {
            bool exec = false;
            MySqlCommand sentencia = new MySqlCommand(String.Format("INSERT INTO productos VALUE(null,'"+name+"', "+precio+", '"+des+"', "+cant+")"), connector());
            MySqlDataReader lector = sentencia.ExecuteReader();
            if (lector.RecordsAffected > 0)
            {
                exec = true;
            }
            else
            {
                exec = false;
            }
            lector.Close();
            return exec;
        }
        public static DataTable Read()
        {
            string ins = "SELECT * FROM productos";
            MySqlDataAdapter sentencia = new MySqlDataAdapter(ins, connector());
            DataTable consulta = new DataTable();
            sentencia.Fill(consulta);
            return consulta;
        }
        public static bool update(int id, string name, double precio, int cant, string descripcion)
        {
            bool exec = false;
            MySqlCommand sentencia = new MySqlCommand("UPDATE productos SET nombre ='" + name + "',precio="+ precio + ", stock=" + cant + ", descripcion='" + descripcion + "' WHERE id = " + id, connector());
            MySqlDataReader lector = sentencia.ExecuteReader();
            if (lector.RecordsAffected > 0)
            {
                exec = true;
            }
            else
            {
                exec = false;
            }
            lector.Close();
            return exec;
        }
        public static bool delete(int id) {
            bool exec = false;
            string query = "DELETE FROM productos WHERE id = " + id;
            MySqlCommand sentencia = new MySqlCommand(query, connector());
            MySqlDataReader lector = sentencia.ExecuteReader();
            if (lector.RecordsAffected > 0)
            {
                exec = true;
            }
            else
            {
                exec = false;
            }
            lector.Close();
            return exec;
        }

    }
}
