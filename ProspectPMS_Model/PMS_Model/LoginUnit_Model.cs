using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProspectPMS_Model.PMS_Model
{
    /// <summary>
    /// LoginUnit_Model 实际SQL - Model
    /// </summary>
    public class LoginUnit_Model
    {
        /// <summary>
        /// 登录表（Login表）ID 唯一标识符
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 标识ID 将=登录表ID
        /// </summary>
        public int Login_UserID { get; set; }

        /// <summary>
        /// 用户账号
        /// </summary>
        public string Login_UserName { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string Login_UserPassword { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string Login_UserNickname { get; set; }

        /// <summary>
        /// 用户简介
        /// </summary>
        public string Login_UserVia { get; set; }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string Login_UserTruename { get; set; }

        /// <summary>
        /// 用户身份证号码
        /// </summary>
        public string Login_UserIdcard { get; set; }

        /// <summary>
        /// 用户邮件
        /// </summary>
        public string Login_UserEmail { get; set; }

        /// <summary>
        /// 用户电话号码
        /// </summary>
        public string Login_UserPhone { get; set; }

        /// <summary>
        /// 用户提问
        /// </summary>
        public string Login_Userquestion { get; set; }

        /// <summary>
        /// 用户回答
        /// </summary>
        public string Login_UserAnswer { get; set; }

        /// <summary>
        /// 用户注册证明
        /// </summary>
        public string Login_UserSignatures { get; set; }

        /// <summary>
        /// 用户性别
        /// </summary>
        public string Login_UserSex { get; set; }

        /// <summary>
        /// 用户生日
        /// </summary>
        public DateTime Login_UserBirthday { get; set; }

        /// <summary>
        /// 注册创建时间
        /// </summary>
        public DateTime Login_CreatTime { get; set; }

        /// <summary>
        /// 上一次登录时间
        /// </summary>
        public DateTime Login_LastUserTime { get; set; }

    }
}

#region -- 字段提取
        ///// 登录表（Login表）ID 唯一标识符
        //ID
        ///// 标识ID 将=登录表ID
        //Login_UserID
        ///// 用户账号
        //Login_UserName
        ///// 用户密码
        //Login_UserPassword
        ///// 用户昵称
        //Login_UserNickname
        ///// 用户简介
        //Login_UserVia
        ///// 用户真实姓名
        //Login_UserTruename
        ///// 用户身份证号码
        //Login_UserIdcard
        ///// 用户邮件
        //Login_UserEmail
        ///// 用户电话号码
        //Login_UserPhone
        ///// 用户提问
        //Login_Userquestion
        ///// 用户回答
        //Login_UserAnswer
        ///// 用户注册证明
        //Login_UserSignatures
        ///// 用户性别
        //Login_UserSex
        ///// 用户生日
        //Login_UserBirthday
        ///// 注册创建时间
        //Login_CreatTime
        ///// 上一次登录时间
        //Login_LastUserTime
#endregion