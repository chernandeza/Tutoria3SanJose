using System;
using System.Data.SqlClient;

namespace LibreriaT3SJ
{
    public class ConectorBD
    {
        #region Class Attributes
        private SqlConnectionStringBuilder ConnectionStr;
        private SqlConnection DBConnection; //Conexion a BD
        private SqlCommand SQLcmd; //Comando SQL a ejecutar en BD
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
                    String commando = "INSERT INTO Persona (cedula, nombre, apellido1, apellido2, provincia, genero, autorizada) ";
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
                    commando += "', 0";
                    commando += ");";
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

        public Persona CargarInformacionPersona(String cedula)
        {
            try
            {
                Persona P = new Persona();
                DBConnection.Open();
                String comando = "SELECT nombre, apellido1, apellido2, provincia, genero";
                comando += " FROM persona WHERE cedula='";
                comando += cedula;
                comando += "';";
                //elw.writeWarning(comando);
                SqlDataReader lectorBD;
                using (DBConnection = new SqlConnection(ConnectionStr.ConnectionString))
                {
                    using (SQLcmd = new SqlCommand(comando, DBConnection))
                    {
                        DBConnection.Open();
                        lectorBD = SQLcmd.ExecuteReader();
                        if (lectorBD.HasRows)
                        {
                            lectorBD.Read();
                            P.Cedula = cedula;
                            P.Nombre = lectorBD.GetString(0);
                            P.Apellido1 = lectorBD.GetString(1);
                            P.Apellido2 = lectorBD.GetString(2);
                            //elw.writeWarning(lectorBD.GetInt16(3).ToString());
                            P.Provincia1 = (Provincia)Enum.ToObject(typeof(Provincia), lectorBD.GetInt16(3));
                            P.Genero = (Genero)Enum.Parse(typeof(Genero), lectorBD.GetString(4));
                        }
                        else
                        {
                            return new Persona();
                        }
                        return P;
                    }
                }
                /*El lectorBD lee fila por fila. Para cada fila trae los datos indicados en el SELECT.
                  El select de este metodo retorna:
                    - String nombre,
                    - String apellido1, 
                    - String apellido2,
                    - int provincia
                    - String Genero
                    Entonces para el data reader esto viene en un arreglo asi:
                    |--------|-----------|-----------|-----------|--------|
                    | nombre | apellido1 | apellido2 | provincia | genero | 
                    |--------|-----------|-----------|-----------|--------|
                        0           1           2           3          4
                */
            }
            catch (Exception E)
            {
                elw.writeError(E.Message);
                throw;
            }
            finally
            {
                DBConnection.Close();
            }
        }
    }
}
