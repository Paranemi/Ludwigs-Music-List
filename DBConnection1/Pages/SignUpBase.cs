using DBConnection1.Data;
using DBConnection1.Models;
using Microsoft.AspNetCore.Components;

namespace DBConnection1.Pages
{
    public class SignUpBase : ComponentBase
    {
        protected string NewUser { get; set; }
        protected string Password { get; set; }
        protected string Confirm { get; set; }
        protected string Test { get; set; }
        protected string Output { get; set; }

        [Inject]
        protected AppDataContext Db { get; set; }

        protected void CreateNewUser()
        {
            Output = NewUser + Password + Confirm + Test;
            if (Check())
            {
                var user = new User
                {
                    UserName = NewUser,
                    Password = Password
                };
                Db.User.Add(user);

                Db.SaveChanges();
                Test = "user wurde angelegt";
            }
            else
            {
                Test = "user wurde nicht angelegt";
            }
        }

        protected bool Check()
        {
            if (Password == Confirm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void UserNameValueChanged(string Value)
        {
            NewUser = Value;
        }
        protected void PasswordValueChanged(string Value)
        {
            Password = Value;
        }
        protected void ConfirmValueChanged(string Value)
        {
            Confirm = Value;
        }
    }
}
