using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Contracts
{
    public interface IUserDomainModel
    {
        Guid UserId { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string SecurityAnswer { get; set; }
    }
}
