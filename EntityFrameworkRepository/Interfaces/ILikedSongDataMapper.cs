using DomainModels;
using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRepository.Interfaces
{
    public interface ILikedSongDataMapper
    {
        ILikedSongDomainModel ToDomainModel(LikedSongEntityModel entityModel);

        LikedSongEntityModel ToEntityModel(ILikedSongDomainModel domainModel);
    }
}
