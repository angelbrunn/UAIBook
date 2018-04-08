using System;
using System.Data;
using System.Data.SqlClient;


namespace DAL.GTW
{
    /// <summary>
    /// Implementar el patron CRUD
    /// </summary>
    internal static class GeneroGateway
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectAll()
        {
            //lppa - qwerty
            var cadena = System.Configuration.ConfigurationManager.ConnectionStrings["uaibook"].ConnectionString;
            
            var cnn = new SqlConnection(cadena);
            try
            {
                
                cnn.Open();
                var cmd = new SqlCommand("GeneroSelectAll", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception)
            {
                throw; //Services Layer - Gestor de Traza y Errores!!!!!
            }
            finally
            {
                cnn.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectOne(Int32 id)
        {
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        public static void Insert()
        { 
        }
    }
}
