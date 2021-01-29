using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.Contracts;

namespace MusicListWorkflow.Contracts
{
    public interface ILikedAlbumWorkflow
    {
        void CreateLikedAlbum(ILikedAlbumViewModel likedAlbumViewModel);

        void DeleteLikedAlbumById(Guid likedAlbumId);

        //für icollection workaround
       // void GetLikedAlbumByUserId(Guid userId);
    }
}
