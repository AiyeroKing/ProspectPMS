using Dapper;
using Dapper.Common;
using ProspectPMS_Model.PMS_Model;
using System.Data.Common;

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
                    LoginUnit_Model model = new LoginUnit_Model();
                    model.Login_UserName = AccountName;
                    model.Login_UserPassword = AccountPassword;
                    result = conn.Execute(AddAccount_Sqlstr, model);
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
