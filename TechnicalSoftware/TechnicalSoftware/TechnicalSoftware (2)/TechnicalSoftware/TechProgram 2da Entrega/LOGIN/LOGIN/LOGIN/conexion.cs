using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    class conexion
    {
        MySqlConnection conexionBD;
        static string servidor = "localhost";
        static string nombreBD = "polideportivo";
        static string usuario = "root";
        static string password = "";
        static string puerto = "3306";
        string cadena = "server ="+servidor+";port="+puerto+";user id="+usuario+";password ="+password+";database ="+ nombreBD+";";
            
        public bool Abrir() { 
                try
                {
                    cadena = "server =" + servidor + ";port=" + puerto + ";user id=" + usuario + ";password =" + password + ";database =" + nombreBD + ";";
                    conexionBD = new MySqlConnection(cadena);
                    conexionBD.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error ! " + ex.Message, "Information");
                } 
                return false;
        }

        public void Cerrar()
        {
            conexionBD.Close();
            conexionBD.Dispose();
        }

        public DataSet EjecutarDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexionBD);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public MySqlDataReader EjecutarDataReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, conexionBD);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }


        public int ExcecuteNonQuery(string sql)
        {
            try
            {
                int affected;
                MySqlTransaction mytransaction = conexionBD.BeginTransaction();
                MySqlCommand cmd = conexionBD.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
    }
}
