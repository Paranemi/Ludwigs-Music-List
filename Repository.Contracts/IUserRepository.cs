using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IUserRepository
    {
        void CreateUser(IUserDomainModel userDomainModel);

        IUserDomainModel GetUserByName(string userName);


    }
}
