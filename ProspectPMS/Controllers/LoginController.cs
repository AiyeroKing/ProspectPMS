using ProspectPMS_Bll.LoginUnit;
using ProspectPMS_Model.PMS_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProspectPMS.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        #region  --登陆页面
        public ActionResult LoginIndex()
        {
            return View();
        }

        [HttpPost]
        public JsonResult LoginAction(string Account ,string password)
        {
            //赋值待用
            string AccountName = Account;
            string AccountPassword = password;
            SignUp_Bll spx = new SignUp_Bll();
            bool result = true;
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region --注册页面
        public ActionResult SignUpIndex()
        {
            return View();
        }


        [HttpPost]

        public JsonResult SignUpAction(string Login_UserName, string Login_UserPassword,string Login_UserNickname,string Login_UserVia, string Login_UserTruename, string Login_UserIdcard,
            string Login_UserEmail, string Login_UserPhone, string Login_Userquestion, string Login_UserAnswer, string Login_UserSignatures, string Login_UserSex, string reLogin_UserPassword)
        {
            //赋值待用
            LoginUnit_Model model = new LoginUnit_Model();
            #region -赋值
            model.Login_UserName = Login_UserName;
            model.Login_UserPassword = Login_UserPassword;
            model.Login_CreatTime = DateTime.Now.ToLocalTime();
            model.Login_LastUserTime = model.Login_CreatTime;
            model.Login_UserAnswer = Login_UserAnswer;
            model.Login_UserBirthday = DateTime.Now.ToLongDateString().ToString();
            model.Login_UserIdcard = Login_UserIdcard;
            model.Login_UserNickname = Login_UserNickname;
            model.Login_UserPhone = Login_UserPhone;
            model.Login_Userquestion = Login_Userquestion;
            model.Login_UserAnswer = Login_UserAnswer;
            model.Login_UserSex = Login_UserSex;
            model.Login_UserVia = Login_UserVia;
            model.Login_UserSignatures = Login_UserSignatures;
            model.Login_UserTruename = Login_UserTruename;
            model.Login_UserID = model.Login_UserName;
            model.Login_UserEmail = Login_UserEmail;
            #endregion
            
            SignUp_Bll spx = new SignUp_Bll();
            bool result = spx.SignUp_AddAccount_Bll(model);
            return Json(result,JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}