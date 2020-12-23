using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBConnection1.Pages
{
    public class SignInBase : ComponentBase
    {
        protected string Day { get; set; } = DateTime.Now.DayOfWeek.ToString();
        protected string User { get; set; }
        protected string Password{ get; set; }
        protected void UserNameChange(ChangeEventArgs eventArgs)
        {
            User = eventArgs.Value.ToString();
        }

        protected void UserNameValueChanged(string Value)
        {
            User = Value;
        }
    }
}
