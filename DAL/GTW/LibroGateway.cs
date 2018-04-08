using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.GTW
{
    public class LibroGateway
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
                var cmd = new SqlCommand("LibroSelectAll", cnn);
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
            //lppa - qwerty
            var cadena = System.Configuration.ConfigurationManager.ConnectionStrings["uaibook"].ConnectionString;

            var cnn = new SqlConnection(cadena);
            try
            {

                cnn.Open();
                var cmd = new SqlCommand("LibroSelect", cnn);
                cmd.Parameters.Add(new SqlParameter("@Id", id));
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
        public static void Insert(String titulo)
        {
            //lppa - qwerty
            var cadena = System.Configuration.ConfigurationManager.ConnectionStrings["uaibook"].ConnectionString;

            var cnn = new SqlConnection(cadena);
            try
            {

                cnn.Open();
                var cmd = new SqlCommand("LibroInsert", cnn);

                cmd.Parameters.Add(new SqlParameter("@Titulo", titulo));
                PrepareAuditCreated(cmd);

                cmd.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                da.Fill(ds);
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
        public static void Update(Int32 id, String titulo)
        {
            //lppa - qwerty
            var cadena = System.Configuration.ConfigurationManager.ConnectionStrings["uaibook"].ConnectionString;

            var cnn = new SqlConnection(cadena);
            try
            {

                cnn.Open();
                var cmd = new SqlCommand("LibroUpdate", cnn);
                //Agregar todos los parametros necesararios
                cmd.Parameters.Add(new SqlParameter("@Id", id));
                cmd.Parameters.Add(new SqlParameter("@Titulo", titulo));
                PrepareAuditChanged(cmd);

                cmd.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                da.Fill(ds);
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
        /// <param name="cmd"></param>
        private static void PrepareAuditCreated(SqlCommand cmd)
        {
            cmd.Parameters.Add(new SqlParameter("@CreatedOn", DateTime.Now));
            cmd.Parameters.Add(new SqlParameter("@CreatedBy", 1));
            cmd.Parameters.Add(new SqlParameter("@ChangedOn", DBNull.Value));
            cmd.Parameters.Add(new SqlParameter("@ChangedBy", DBNull.Value));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        private static void PrepareAuditChanged(SqlCommand cmd)
        {
            cmd.Parameters.Add(new SqlParameter("@ChangedOn", DateTime.Now));
            cmd.Parameters.Add(new SqlParameter("@ChangedBy", 1));
        }
    }
}
