using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Contracts
{
    public interface IUserViewModel
    {

        Guid UserId { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string SecurityAnswer { get; set; }

    }
}
