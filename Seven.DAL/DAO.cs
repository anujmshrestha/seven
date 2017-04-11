using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.DAL
{
    public static class DAO
    {
       
        public static AppSettingsReader aps = new AppSettingsReader();
        //returns connction as datatable function returns data
        public static SqlConnection GetConnection()
        {
                SqlConnection con = new SqlConnection(aps.GetValue("myconnection", typeof(string)).ToString());
                if (con.State != ConnectionState.Open)
                {
                    con.Open();

                }
                return con;

        }
        public static int IUD(string sql,SqlParameter [] param,CommandType cmdType)
        {
            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = cmdType;
                    if(param!=null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    return cmd.ExecuteNonQuery();

                }
            }
        }
        public static DataTable  GetTable(string sql, SqlParameter[] param, CommandType cmdType)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = cmdType;
                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;

                }
            }
        }

    } 
}
