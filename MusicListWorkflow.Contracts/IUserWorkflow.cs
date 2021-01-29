using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.Contracts;

namespace MusicListWorkflow.Contracts
{
    public interface IUserWorkflow
    {
        void CreateUser(IUserViewModel userDomainModel);

        IUserViewModel GetUserByName(string userName);

        
    }
}
