using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seven.DAL;

namespace Seven.BLL
{
    public   class BLLProduct
    {
        public int CreateProduct(int categoryid, string productname, decimal unitprice)
        {
            
            string sql = "insert into tblProduct values(@categoryid,@productname,@unitprice)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("categoryid",categoryid),
                new SqlParameter("@productname", productname),
                new SqlParameter("@unitprice", unitprice)
            };
            int i = DAO.IUD(sql, param, CommandType.Text);
            return i;
        }
        public int UpdateProduct(int categoryid, string productname, decimal unitprice, int productid)
        {
            
            string sql = "update tblProduct set CategoryId=@categoryid,ProductName=@productname,UnitPrice=@unitprice where ProductId=@productid";
            SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@categoryid", categoryid),
            new SqlParameter("@productname  ",productname),
            new SqlParameter("@unitprice",unitprice),
            new SqlParameter("@productid", productid)
        };

            return DAO.IUD(sql, param, CommandType.Text);

        }
        public int DeleteProduct(int productid)
        {
           
            string sql = "delete from tblProduct where ProductId=@productid";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@productid",productid)
            };
            return DAO.IUD(sql, param, CommandType.Text);


            

        }
        public DataTable GetAllProduct()
        {
            string sql = "SELECT        tblCategory.CategoryName,tblProduct.ProductId, tblProduct.ProductName, tblProduct.UnitPrice FROM tblCategory INNER JOIN tblProduct ON tblCategory.CategoryID = tblProduct.CategoryId";
            return DAO.GetTable(sql, null, CommandType.Text);

        }
        public DataTable GetProductByProductId(int productid)
        {
            
            string sql = "select *from tblProduct where ProductId=@a";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@productid",productid)
            };
            return DAO.GetTable(sql, param, CommandType.Text);

        }
        public DataTable GetProductByCatId(int categoryid)
        {
           
            string sql = "select *from tblProduct where CategoryId=@a";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@categoryid",categoryid)

            };
            return DAO.GetTable(sql, param, CommandType.Text);
           

        }

    }
}
