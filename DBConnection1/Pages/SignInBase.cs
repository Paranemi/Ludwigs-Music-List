using BlazorServerSide.Shared;
using EntityFrameworkRepository.EFModels;
using Microsoft.AspNetCore.Components;
using MusicListWorkflow.Contracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ViewModels;

namespace BlazorServerSide.Pages
{
    public class SignInBase : ComponentBase
    {
        protected string Day { get; set; } = DateTime.Now.DayOfWeek.ToString();
        protected string Error { get; set; }

        protected Validation User { get; set; } = new Validation();

        [Inject]
        public GlobalVariables GlobalVariables { get; set; }
        [Inject]
        public NavigationManager UriHelper { get; set; }
        [Inject]
        public IUserWorkflow UserWorkflow { get; set; }

        protected void Test()
        {

            

            if (User.UserName != null)
            {
                try
                {
                    var user = UserWorkflow.GetUserByName(User.UserName);

                    if(user == null)
                    {
                        Error = "user name unknown";
                    }
                    else
                    {
                        if (user.Password == User.Password)
                        {
                            GlobalVariables.ActiveUser = User.UserName;
                            UriHelper.NavigateTo("/songlist", true);
                        }
                        else
                        {
                            Error = "wrong password";
                        }
                    }
                }
                catch (Exception)
                {
                    Error = "wrong user name";
                }
            }
        }
        protected void UserNameChange(ChangeEventArgs eventArgs)
        {
            User.UserName = eventArgs.Value.ToString();
        }

        protected void UserNameValueChanged(string Value)
        {
            User.UserName = Value;
        }
        protected void PasswordValueChanged(string Value)
        {
            User.Password = Value;
        }

    }
}
