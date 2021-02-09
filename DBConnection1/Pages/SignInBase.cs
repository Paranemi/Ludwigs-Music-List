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
        protected string Hallo { get; set; }

        protected Validation User { get; set; } = new Validation();

        [Inject]
        public GlobalVariables GlobalVariables { get; set; }
        [Inject]
        public NavigationManager UriHelper { get; set; }
        [Inject]
        public IUserWorkflow UserWorkflow { get; set; }

        protected void Test()
        {

            var user = UserWorkflow.GetUserByName(User.UserName);

            if (user != null)
            {
                if (user.Password == User.Password)
                {
                    GlobalVariables.ActiveUser = User.UserName;
                    UriHelper.NavigateTo("/", true);
                }
                else
                {
                    Hallo = "password is wrong";
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
