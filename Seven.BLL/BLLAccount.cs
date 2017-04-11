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
    public class BLLAccount
    {
        public int TransferAmount(string accountnoA, string accountnoB, decimal amount)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@amount",amount),
                new SqlParameter("accountnoA",accountnoA),
                new SqlParameter("accountnoB",accountnoB)

            };
            return DAO.IUD("TransferAmount", param, CommandType.Text);

        }
        public DataTable GetAccountDetailsByAccountNo(string accountno)
        {
            SqlParameter[] param = new SqlParameter[]
            {


                new SqlParameter("@accountno",accountno)

            };
            return DAO.GetTable("select *from tblAccount  where AccountNo=@accountno", param, CommandType.StoredProcedure);

        }

    }
}
