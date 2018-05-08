using ProspectPMS_Dal.LoginUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProspectPMS_Bll.LoginUnit
{
   public class SignUp_Bll
    {
        /// <summary>
        /// 添加账号和密码
        /// </summary>
        /// <param name="Account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool SignUp_AddAccount_Bll(string AccountName, string AccountPassword)
        {
            SignUp_Dal spx = new SignUp_Dal();
            int get_result = spx.SignUp_AddAccount_Dal(AccountName, AccountPassword);
            bool result=false;
            if(get_result<0 || get_result == 0)
            {
            }
            else
            {
                result = true;
            }
            return result;
        }

    }
}
