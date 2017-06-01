using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccessLayer
{
    public class DBConnection
    {
        const string DBConnectionString = "Server=.;Database=PersonalInfoDemo;user id=sa;password=724964;Trusted_Connection=false;pooling=false;";

        internal static DataTable GetDataTable(string CommandName, CommandType cmdType, SqlParameter[] param)
        {
            DataTable dt = null;

            using(SqlConnection dbCon = new SqlConnection(DBConnectionString))
            {
                using(SqlCommand cmd = dbCon.CreateCommand())
	            {
		            cmd.CommandText = CommandName;
                    cmd.CommandType = cmdType;
                    if (param.Length>0)
                    {
                        cmd.Parameters.AddRange(param);
                    }

                    try 
	                {
                        if (dbCon.State != ConnectionState.Open)
                        {
                            dbCon.Open();
                        }
                        using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                        {
                            dt = new DataTable();
                            adp.Fill(dt);
                        }
	                }
	                catch (Exception)
	                {
		
		                throw;
	                }
	            }
            }

            return dt;
        }

        internal static bool ExecureNoneQuery(string CommandName, CommandType cmdType, SqlParameter[] paras)
        {
            int result = 0;
            using (SqlConnection dbCon = new SqlConnection(DBConnectionString))
            {
                using (SqlCommand cmd = dbCon.CreateCommand())
                {
                    cmd.CommandText = CommandName;
                    cmd.CommandType = cmdType;
                    if (paras.Length>0)
                    {
                        cmd.Parameters.AddRange(paras);
                    }

                    try 
	                {
                        if (dbCon.State != ConnectionState.Open)
                        {
                            dbCon.Open();
                        }
                        result = cmd.ExecuteNonQuery();
	                }
	                catch (Exception)
	                {
		
		                throw;
	                }
                }
            }
            return (result>0);
        }

        internal static string GetStringValue(string commandText)
        {
            string str = "";
            using (SqlConnection dbCon = new SqlConnection(DBConnectionString))
            {
                try
                {

                    try
                    {
                        if (dbCon.State != ConnectionState.Open)
                        {
                            dbCon.Open();
                        }
                        SqlCommand cmd = new SqlCommand(commandText, dbCon);
                        cmd.CommandTimeout = 0;
                        str = cmd.ExecuteScalar().ToString();
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    return str;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    return str;
                }
            }
        }
    }
}
