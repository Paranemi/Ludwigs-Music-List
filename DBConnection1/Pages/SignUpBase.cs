using Microsoft.AspNetCore.Components;
using MusicListWorkflow.Contracts;
using ViewModels;

namespace BlazorServerSide.Pages
{
    public class SignUpBase : ComponentBase
    {
        protected string NewUser { get; set; }
        protected string Password { get; set; }
        protected string Confirm { get; set; }
        protected string SecurityAnswer { get; set; }
        protected string Test { get; set; }
        protected string Output { get; set; }

        [Inject]
        public IUserWorkflow UserWorkflow { get; set; }

        protected void CreateNewUser()
        {
            if (Check())
            {
                

                var user = new UserViewModel()
                {
                    UserName = NewUser,
                    Password = Password,
                    SecurityAnswer = SecurityAnswer
                };
                UserWorkflow.CreateUser(user);
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
        protected void SecurityAnswerValueChanged(string Value)
        {
            SecurityAnswer = Value;
        }
    }
}
