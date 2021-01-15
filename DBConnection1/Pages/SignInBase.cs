using DBConnection1.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.ComponentModel.DataAnnotations;
using DBConnection1.Models;
using System.Linq;

namespace DBConnection1.Pages
{
    public class SignInBase : ComponentBase
    {
        protected string Day { get; set; } = DateTime.Now.DayOfWeek.ToString();

        [Required(ErrorMessage = "user name is required")]
        protected string Username { get; set; }
        [Required(ErrorMessage = "password is required")]
        protected string Password{ get; set; }
        protected string Hallo { get; set; }

        [Inject]
        public AppDataContext Db { get; set; }
        [Inject]
        public GlobalVariables GlobalVariables { get; set; }

        protected void Test()
        {
            var user = Db.User.Where(b => b.UserName.Contains(Username)).ToList();
            var pw = Db.User.Where(b => b.Password.Contains(Password)).ToList();
            if (user.Count > 0)
            {
                Hallo = "User Existiert";
                if(pw.Count > 0)
                {
                    Hallo = "User Existiert und PW ist richtig";
                    
                }
                else
                {
                    Hallo = "User Existiert aber PW ist falsch";
                    GlobalVariables = Username;
                }
            }
            else{
                Hallo = "User Existiert nicht";
            }

        }
        protected void UserNameChange(ChangeEventArgs eventArgs)
        {
            Username = eventArgs.Value.ToString();
        }

        protected void UserNameValueChanged(string Value)
        {
            Username = Value;
        }
        protected void PasswordValueChanged(string Value)
        {
            Password = Value;
        }

    }
}
