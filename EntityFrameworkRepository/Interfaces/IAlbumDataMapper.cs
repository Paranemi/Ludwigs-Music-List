using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRepository.Interfaces
{
    public interface IAlbumDataMapper
    {
        IAlbumDomainModel ToDomainModel(AlbumEntityModel entityModel);

        AlbumEntityModel ToEntityModel(IAlbumDomainModel domainModel);
    }
}
