using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
namespace DapperTest
{
    public class DapperHelper
    {
        string sqlConnstr= "Data Source=.;Initial Catalog=TestDb;User Id=sa;Password=123";
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int UserInsert(UserInfo user)
        {
            using (var db=new SqlConnection(sqlConnstr))
            {
                //uID, uLoginName, uLoginPWD, uRealName, uStatus, uRemark, uCreateTime
                string query = "INSERT INTO USERINFO VALUES(@uLoginName, @uLoginPWD, @uRealName, @uStatus, @uRemark, @uCreateTime)";
                return db.Execute(query, user);
            }
        }
        /// <summary>
        /// 批量插入数据
        /// </summary>
        /// <param name="ulist"></param>
        /// <returns></returns>
        public int MultInsertUser(List<UserInfo> ulist)
        {
            using (var db = new SqlConnection(sqlConnstr))
            {
                string query = "INSERT INTO USERINFO VALUES(@uLoginName, @uLoginPWD, @uRealName, @uStatus, @uRemark, @uCreateTime)";
                return db.Execute(query,ulist);
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Uid"></param>
        /// <returns></returns>
        public int UserDelete(int Uid)
        {
            using (var db=new SqlConnection(sqlConnstr))
            {
                string query = "DELETE  USERINFO WHERE uID=@Uid";
                var param = new DynamicParameters();
                param.Add("Uid", Uid);
                return db.Execute(query,param);

            }
        }
        public int MultDeleteUser(List<UserInfo> ulist)
        {
            using (var db=new SqlConnection(sqlConnstr))
            {
                string query = "DELETE  USERINFO WHERE uID=@Uid";
                return db.Execute(query, ulist);
            }
        }
        public int UserUpdate(UserInfo user)
        {
            //uID, uLoginName, uLoginPWD, uRealName, uStatus, uRemark, uCreateTime
            using (var db=new SqlConnection(sqlConnstr))
            {
                string query= "UPDATE USERINFO SET uLoginName=@uLoginName,uLoginPWD=@uLoginPWD,uRealName=@uRealName,uStatus=@uStatus,uRemark=@uRemark,uCreateTime=@uCreateTime WHERE uID=@uID";
                return db.Execute(query, user);
            }
        }

        public List<UserInfo> GetAll()
        {
            using (var db = new SqlConnection(sqlConnstr))
            {
                string query = "SELECT * FROM USERINFO";
                return db.Query<UserInfo>(query).ToList();

            }
        }
        /// <summary>
        /// 查询多条指定的数据
        /// </summary>
        /// <param name="uids">查询条件</param>
        /// <returns></returns>
        public List<UserInfo> GetAllIn(int[] uids)
        {
            using (var db=new SqlConnection(sqlConnstr))
            {
                string query = "SELECT * FROM USERINFO WHERE uID IN @uids";
                return db.Query<UserInfo>(query, new { uids= uids }).ToList();
            }
        }

     }
}
