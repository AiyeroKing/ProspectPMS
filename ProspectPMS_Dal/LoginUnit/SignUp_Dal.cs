using Dapper;
using Dapper.Common;
using ProspectPMS_Model.PMS_ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProspectPMS_Dal.LoginUnit
{
    public class SignUp_Dal
    {
        public int SignUp_AddAccount_Dal(string AccountName, string AccountPassword)
        {
            int result = 0;
            const string AddAccount_Sqlstr = @"
                               INSERT INTO dbo.List_Login_UserMessage
                                        ( Login_UserName,Login_UserPassword) 
                                VALUES  (
                                        @Login_UserName,
                                        @Login_UserPassword
                                         )";

            try
            {
                using (DbConnection conn = DbFactory.CreateConnection())
                {
                    Login_viewmodel viewmodel = new Login_viewmodel();
                    viewmodel.Login_UserName = AccountName;
                    viewmodel.Login_UserPassword = AccountPassword;
                    result = conn.Execute(AddAccount_Sqlstr, viewmodel);
                    return result;
                }
            }
            catch (System.Exception ex)
            {
                string ex_str = ex.ToString();
                throw;
            }
        }

    }
}
