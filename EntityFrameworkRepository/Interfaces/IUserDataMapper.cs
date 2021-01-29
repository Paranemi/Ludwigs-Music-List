using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRepository.Interfaces
{
    public interface IUserDataMapper
    {
        IUserDomainModel ToDomainModel(UserEntityModel entityModel);

        UserEntityModel ToEntityModel(IUserDomainModel domainModel);
    }
}
