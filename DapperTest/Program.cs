using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.0插入数据
            //UserInfo user = new UserInfo
            //{
            //    uLoginName = "xiaoxiao",
            //    uLoginPWD = "123",
            //    uStatus = 0,
            //    uRealName = "小小",
            //    uRemark = "Test01",
            //    uCreateTime = DateTime.Now
            //};
            //DapperHelper helper = new DapperHelper();
            //int i = helper.UserInsert(user);
            //if (i > 0)
            //{
            //    Console.WriteLine("插入成功");
            //}
            //Console.ReadLine();
            #endregion

            #region 2.0批量插入
            //List<UserInfo> ulist = new List<UserInfo> {
            //    new UserInfo(){uLoginName = "xiaohu", uLoginPWD = "555",uStatus = 0 ,uRealName = "小虎", uRemark = "Test01",uCreateTime = DateTime.Now},
            //    new UserInfo(){uLoginName = "yangyang", uLoginPWD = "888",uStatus = 0 ,uRealName = "杨杨", uRemark = "Test01",uCreateTime = DateTime.Now},
            //};
            //DapperHelper helper = new DapperHelper();
            //int i = helper.MultInsertUser(ulist);
            //if (i > 0)
            //{
            //    Console.WriteLine("批量数据插入成功");
            //}
            //Console.ReadLine();
            #endregion

            #region 3.0删除数据
            //DapperHelper helper = new DapperHelper();
            //int uid = 7;
            //int i = helper.UserDelete(uid);
            //if (i > 0)
            //{
            //    Console.WriteLine("删除成功");
            //}
            //Console.ReadLine();
            #endregion

            #region 4.0批量删除数据
            //List<UserInfo> ulist = new List<UserInfo> {
            //    new UserInfo(){uID=8},
            //    new UserInfo(){uID=9},
            //};
            //DapperHelper helper = new DapperHelper();
            //int i = helper.MultDeleteUser(ulist);
            //if (i > 0)
            //{
            //    Console.WriteLine("批量删除成功");
            //}
            //Console.ReadLine();
            #endregion

            #region 5.0修改数据
            //UserInfo user = new UserInfo
            //{
            //    uID = 2,
            //    uLoginName = "xiaomogu",
            //    uLoginPWD = "555555",
            //    uStatus = 0,
            //    uRealName = "蘑菇",
            //    uRemark = "测试",
            //    uCreateTime = DateTime.Now
            //};
            //DapperHelper helper = new DapperHelper();
            //int i = helper.UserUpdate(user);
            //if (i > 0)
            //{
            //    Console.WriteLine("修改成功");
            //}
            //Console.ReadLine();
            #endregion

            #region 6.0查询所有数据集合
            //DapperHelper helper = new DapperHelper();
            //var list = helper.GetAll();
            //foreach (var item in list)
            //{
            //    Console.WriteLine("用户名：{0},密码:{1}", item.uLoginName, item.uLoginPWD);
            //}
            //Console.ReadLine();
            #endregion

            #region 7.0查询多条指定的数据
            int[] ids = new int[] { 10, 11 };
            DapperHelper helper = new DapperHelper();
            var list = helper.GetAllIn(ids);
            foreach (var item in list)
            {
                Console.WriteLine("用户名：{0},密码:{1}", item.uLoginName, item.uLoginPWD);
            }
            Console.ReadLine();
            #endregion
        }
    }
}
