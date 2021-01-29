using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRepository.Interfaces
{
    public interface IArtistDataMapper
    {
        IArtistDomainModel ToDomainModel(ArtistEntityModel entityModel);

        ArtistEntityModel ToEntityModel(IArtistDomainModel domainModel);
    }
}
