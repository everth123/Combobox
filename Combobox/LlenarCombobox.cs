using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combobox
{
    public class LlenarCombobox
    {
        #region metodo Select Pais
        //Creamos el metodo para listar los paises
        public static DataTable GetPais()
        {
            DataTable dtp = new DataTable("Refrescar");
            //accediendo al archivo de configuracion que contiene la DB
            using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.AppSettings["Default"]))
                try
                {
                    //abrimos la conexion
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = sqlCon;
                    sqlCmd.CommandText = "spGetValorPais";
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    //No hay parametros para declara
                    //Creamos el DataAdapter para llenar el Datatable
                    SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                    sqlDat.Fill(dtp);
                    sqlCon.Close();
                }
                catch (Exception)
                {
                    dtp = null;
                }
            return dtp;
            #endregion
        }
    }
}
