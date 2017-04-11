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
   public  class BLLUser
    {
        public int CreateUser(string username,string password,string usertype,string fullname)
        {
            string sql="insert into tblUser values(@a,@b,@c,@d)";

            SqlParameter[] param=new SqlParameter[]
            {
                    new SqlParameter("@a",username),
                    new SqlParameter("@b",password),
                    new SqlParameter("@c",usertype  ),
                    new SqlParameter("@d", fullname)
             };
        int i = DAO.IUD(sql, param, System.Data.CommandType.Text);
            return i;
        }
        public int UpdateUser(string username,string password,string usertype,string fullname,int userid)
        {
            string sql = "update  tblUser set Username=@a,Password=@b,Usertype=@c,Fullname= @d where UserId=@e";


            SqlParameter[] param = new SqlParameter[]
            {
                    new SqlParameter("@a",username),
                    new SqlParameter("@b",password),
                    new SqlParameter("@c",usertype  ),
                    new SqlParameter("@d", fullname),
                    new SqlParameter("@e", userid)
             };
            int i = DAO.IUD(sql, param, System.Data.CommandType.Text);
            return i;
        }
        public int DeleteUser(int userid)
        {
            string sql = "delete from tblUser where UserId=@e";


            SqlParameter[] param = new SqlParameter[]
            {
                  
                    new SqlParameter("@e", userid)
             };
            int i = DAO.IUD(sql, param, System.Data.CommandType.Text);
            return i;
        }
        public DataTable GetAllUser()
        {
            DataTable dt = DAO.GetTable("select *from tblUser", null, CommandType.Text);
            return dt;
        }
        public DataTable CountUser()
        {

            DataTable dt = DAO.GetTable("select Count(Userid) from tblUser", null, CommandType.Text);
            return dt;

        }
        public DataTable GetUserbyUsername(string username)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@username", username),
            };
            DataTable dt = DAO.GetTable("select *from tblUser where Username=@username ", param, CommandType.Text);
            return dt;
        }
        public DataTable GetUserbyUsernameLike(string username)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@username",username)

            };
            DataTable dt = DAO.GetTable("select *from tblUser where Username like @username", param, CommandType.Text);
            return dt;
        }
        public DataTable CheckUser(string username, string password)
        {
            SqlParameter[] param = new SqlParameter[]
               {
                new SqlParameter("@username",username),
                new SqlParameter("@password",password)

               };
            DataTable dt = DAO.GetTable("select *from tblUser where Username=@username and  Password=@password", param, CommandType.Text);
            return dt;

        }
        
    }
}
