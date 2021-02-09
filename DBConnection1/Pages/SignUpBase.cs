using BlazorServerSide.Shared;
using Microsoft.AspNetCore.Components;
using MusicListWorkflow.Contracts;
using ViewModels;

namespace BlazorServerSide.Pages
{
    public class SignUpBase : ComponentBase
    {
        //protected string NewUser { get; set; }
        //protected string Password { get; set; }
        protected string Confirm { get; set; }
        //protected string SecurityAnswer { get; set; }
        protected string Test { get; set; }
        protected string Output { get; set; }

        protected Validation User { get; set; } = new Validation();

        [Inject]
        public IUserWorkflow UserWorkflow { get; set; }

        protected void CreateNewUser()
        {
            if (Check())
            {
                

                var user = new UserViewModel()
                {
                    UserName = User.UserName,
                    Password = User.Password,
                    SecurityAnswer = User.SecurityAnswer
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

            if (User.Password == Confirm && !string.IsNullOrEmpty(User.UserName) && !string.IsNullOrEmpty(User.Password) && !string.IsNullOrEmpty(User.SecurityAnswer))
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
            User.UserName = Value;
        }
        protected void PasswordValueChanged(string Value)
        {
            User.Password = Value;
        }
        protected void ConfirmValueChanged(string Value)
        {
            Confirm = Value;
        }
        protected void SecurityAnswerValueChanged(string Value)
        {
            User.SecurityAnswer = Value;
        }
    }
}
