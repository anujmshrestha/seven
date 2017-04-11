using Seven.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven.BLL
{
   public  class BLLCategory
    {
        
        public int CreateCategory(string categoryname)
        {


            string sql = "insert into tblCategory values(@a)";
            SqlParameter[] param = new SqlParameter[]
            {
            
                new SqlParameter("@a", categoryname)
                
            };
            int i = DAO.IUD(sql, param, CommandType.Text);
            return i;
        }
        public int DeleteCategory(int categoryid)
        {


            string sql = "delete from tblCategory where CategoryId=@categoryid)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("categoryid",categoryid),
                

            };
            int i = DAO.IUD(sql, param, CommandType.Text);
            return i;
        }
        public DataTable GetAllCategory()
        {
            string sql = "select *from tblCategory";
            return DAO.GetTable(sql, null, CommandType.Text);


        }

    }
}
