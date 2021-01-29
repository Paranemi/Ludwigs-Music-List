using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRepository.Interfaces
{
    public interface ILikedAlbumDataMapper
    {
        ILikedAlbumDomainModel ToDomainModel(LikedAlbumEntityModel entityModel);

        LikedAlbumEntityModel ToEntityModel(ILikedAlbumDomainModel domainModel);

    }
}
