using ProspectPMS_Bll.LoginUnit;
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
        public bool LoginAction(string Account ,string password)
        {
            bool result = true;
            
            return result;
        }
        #endregion

        #region --注册页面
        public ActionResult SignUpIndex()
        {
            return View();
        }


        [HttpPost]
        public JsonResult SignUpAction(string Account, string password)
        {
            //赋值待用
            string AccountName = Account;
            string AccountPassword = password;
            SignUp_Bll spx = new SignUp_Bll();
            bool result = spx.SignUp_AddAccount_Bll(AccountName, AccountPassword);
            return Json(result,JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}