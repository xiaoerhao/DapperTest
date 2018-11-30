using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTest
{
    public class UserInfo
    {
        //uID, uLoginName, uLoginPWD, uRealName, uStatus, uRemark, uCreateTime
       /// <summary>
       /// 主键
       /// </summary>
        public int uID { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string uLoginName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string uLoginPWD { get; set; }
        /// <summary>
        /// 真实名字
        /// </summary>
        public string uRealName { get; set; }
        /// <summary>
        /// 状态，0表示正常，1表示删除
        /// </summary>
        public int uStatus { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string uRemark { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime uCreateTime { get; set; }
    }
}
