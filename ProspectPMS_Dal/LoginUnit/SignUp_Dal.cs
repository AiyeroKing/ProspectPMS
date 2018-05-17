using Dapper;
using Dapper.Common;
using ProspectPMS_Model.PMS_Model;
using System.Data.Common;

namespace ProspectPMS_Dal.LoginUnit
{
    public class SignUp_Dal
    {
        public int SignUp_AddAccount_Dal(LoginUnit_Model model)
        {
            int result = 0;
            const string AddAccount_Sqlstr = @"
                               INSERT INTO dbo.List_Login_UserMessage
                                        ( 
                                          Login_UserID,
                                          Login_UserName,
                                          Login_UserPassword,
                                          Login_UserNickname,
                                          Login_UserVia,
                                          Login_UserTruename,
                                          Login_UserIdcard,
                                          Login_UserEmail,
                                          Login_UserPhone,
                                          Login_Userquestion,
                                          Login_UserAnswer,
                                          Login_UserSignatures,
                                          Login_UserSex,
                                          Login_UserBirthday,
                                          Login_CreatTime,
                                          Login_LastUserTime
                                        ) 
                                VALUES  (
                                          @Login_UserID,
                                          @Login_UserName,
                                          @Login_UserPassword,
                                          @Login_UserNickname,
                                          @Login_UserVia,
                                          @Login_UserTruename,
                                          @Login_UserIdcard,
                                          @Login_UserEmail,
                                          @Login_UserPhone,
                                          @Login_Userquestion,
                                          @Login_UserAnswer,
                                          @Login_UserSignatures,
                                          @Login_UserSex,
                                          @Login_UserBirthday,
                                          @Login_CreatTime,
                                          @Login_LastUserTime
                                         )";

            try
            {
                using (DbConnection conn = DbFactory.CreateConnection())
                {
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
