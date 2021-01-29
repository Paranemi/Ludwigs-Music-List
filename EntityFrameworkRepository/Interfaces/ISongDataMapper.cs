using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRepository.Interfaces
{
    public interface ISongDataMapper
    {
        ISongDomainModel ToDomainModel(SongEntityModel entityModel);

        SongEntityModel ToEntityModel(ISongDomainModel domainModel);
    }
}
