using DBConnection1.Data;
using DBConnection1.Models;
using Microsoft.AspNetCore.Components;

namespace DBConnection1.Pages
{
    public class SignUpBase : ComponentBase
    {
        public string NewUser { get; set; }
        public string Password { get; set; }
        public string Confirm { get; set; }
        public string Test { get; set; }
        public string Output { get; set; }

        [Inject]
        public AppDataContext Db { get; set; }

        public void CreateNewUser()
        {
            Output = NewUser + Password + Confirm + Test;
            if (Check())
            {
                var user = new User
                {
                    UserName = NewUser,
                    Password = this.Password
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

        public bool Check()
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
