using Microsoft.AspNetCore.Components;
using MusicListWorkflow.Contracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BlazorServerSide.Pages
{
    public class SignInBase : ComponentBase
    {
        protected string Day { get; set; } = DateTime.Now.DayOfWeek.ToString();

        [Required(ErrorMessage = "user name is required")]
        protected string Username { get; set; }
        [Required(ErrorMessage = "password is required")]
        protected string Password { get; set; }
        protected string Hallo { get; set; }

        [Inject]
        public GlobalVariables GlobalVariables { get; set; }
        [Inject]
        public NavigationManager UriHelper { get; set; }
        [Inject]
        public IUserWorkflow UserWorkflow { get; set; }

        protected void Test()
        {
            var user = UserWorkflow.GetUserByName(Username);

            if (user != null)
            {
                Hallo = "User existiert";
                if (user.Password == Password)
                {
                    Hallo = "User existiert und PW ist richtig";
                    GlobalVariables.ActiveUser = Username;
                    UriHelper.NavigateTo("/", true);
                }
                else
                {
                    Hallo = "User existiert aber PW ist falsch";
                }
            }
            else
            {
                Hallo = "User existiert nicht";
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
