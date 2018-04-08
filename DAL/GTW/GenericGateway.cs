using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL.GTW
{
    internal abstract class GenericGateway
    {
        protected SqlConnection getConnection(){
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["uaibook"].ConnectionString);
            connection.Open();
            return connection;
        }

        protected DataTable SelectAll(String procedure)
        {
            SqlConnection cnx = null;
            try
            {
                getConnection();
                SqlCommand command = new SqlCommand(procedure, cnx);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDA = new SqlDataAdapter(command);

                DataSet ds = new DataSet();

                sqlDA.Fill(ds);

                return ds.Tables[0];
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cnx != null){
                    cnx.Close();
                }
            }
        }

        protected DataTable SelectOne(String procedure)
        {
            return null;
        }

        protected void Insert(String procedure)
        {

        }

        protected void Update(String procedure)
        {

        }

        protected void Delete(String procedure)
        {

        }
    
    }
}
