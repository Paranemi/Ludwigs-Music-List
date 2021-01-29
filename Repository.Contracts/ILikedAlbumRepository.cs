using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicListWorkflow.Contracts
{
    public interface ILikedAlbumRepository
    {
        void CreateLikedAlbum(ILikedAlbumDomainModel likedAlbumDomainModel);

        void DeleteLikedAlbumById(Guid likedAlbumId);

        //für icollection workaround
        //void GetLikedAlbumByUserId(Guid userId);
    }
}
