using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRepository.Interfaces
{
    public interface IPersonDataMapper
    {
        IPersonDomainModel ToDomainModel(PersonEntityModel entityModel);

        PersonEntityModel ToEntityModel(IPersonDomainModel domainModel);
    }
}
