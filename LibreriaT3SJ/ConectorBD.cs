using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibreriaT3SJ
{
    public class ConectorBD
    {
        #region Class Attributes
        private SqlConnectionStringBuilder ConnectionStr;
        private SqlConnection DBConnection;
        private SqlCommand SQLcmd;
        private EvtLogWriter elw;
        #endregion

        /// <summary>
        /// Base class constructor. Initializes the connection to the DB with the specific parameters.            
        /// </summary>
        public ConectorBD()
        {
            try
            {
                ConnectionStr = new SqlConnectionStringBuilder();
                ConnectionStr.DataSource = ".\\SQLEXPRESS";
                ConnectionStr.InitialCatalog = "T3SJTest1";
                ConnectionStr.IntegratedSecurity = true;
                DBConnection = new SqlConnection(ConnectionStr.ConnectionString);
                elw = new EvtLogWriter("InfoPersonas", "Application");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void GuardarListaenBD(ListaPersonas lp)
        {
            try
            {
                DBConnection.Open();
                foreach (Persona item in lp.ListaP.Values)
                {
                    String commando = "INSERT INTO Persona (cedula, nombre, apellido1, apellido2, provincia, genero) ";
                    commando += "VALUES ('";
                    commando += item.Cedula;
                    commando += "', '";
                    commando += item.Nombre;
                    commando += "', '";
                    commando += item.Apellido1;
                    commando += "', '";
                    commando += item.Apellido2;
                    commando += "', ";
                    commando += (int)item.Provincia1;
                    commando += ", '";
                    commando += item.Genero.ToString();
                    commando += "');";
                    SQLcmd = new SqlCommand(commando, DBConnection);
                    elw.writeWarning(commando);
                    SQLcmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DBConnection.Close();
            }
        }
    }
}
