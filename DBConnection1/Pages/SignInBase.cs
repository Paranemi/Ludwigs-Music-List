using DBConnection1.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBConnection1.Pages
{
    public class SignInBase : ComponentBase
    {
        protected string Day { get; set; } = DateTime.Now.DayOfWeek.ToString();

        [Required(ErrorMessage = "user name is required")]
        protected string Username { get; set; }
        protected string Password{ get; set; }
        protected void UserNameChange(ChangeEventArgs eventArgs)
        {
            Username = eventArgs.Value.ToString();
        }

        protected void UserNameValueChanged(string Value)
        {
            Username = Value;
        }
    }
}
