using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using EmployeeBEL;

namespace EmployeeDAL
{
    public class EmployeeAccess
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);

        public int SaveEmployeeDetails(Employee objBEL)

        {
            int result;

            try

            {
                SqlCommand cmd = new SqlCommand("InsertEmpDetails_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", objBEL.Name);
                cmd.Parameters.AddWithValue("@Age", objBEL.Age);
                cmd.Parameters.AddWithValue("@Email", objBEL.Email);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                result = cmd.ExecuteNonQuery();
                cmd.Dispose();

                if (result > 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }

            catch(Exception ex)
            {
                throw;
            }

            finally
            {
                if(con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        public DataSet GetEmpRecords()
        {
            DataSet ds = new DataSet();

            try
            {
                SqlCommand cmd = new SqlCommand("FetchEmpDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(ds);
                cmd.Dispose();
            }

            catch
            {
                throw;
            }

            finally
            {
                ds.Dispose();
            }
            return ds;
        }

        public int UpdateEmployee(Employee objBEL)
        {
            int result;
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateEmpRecord_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", objBEL.ID);
                cmd.Parameters.AddWithValue("@Name", objBEL.Name);
                cmd.Parameters.AddWithValue("@Age", objBEL.Age);
                cmd.Parameters.AddWithValue("@Email", objBEL.Email);

                if(con.State== ConnectionState.Closed)
                {
                    con.Open();
                }
                result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                if(result > 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }

            catch
            {
                throw;
            }
        }

    }
}
