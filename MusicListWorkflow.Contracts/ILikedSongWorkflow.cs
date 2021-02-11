using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.Contracts;

namespace MusicListWorkflow.Contracts
{
    public interface ILikedSongWorkflow
    {
        void CreateLikedSong(ILikedSongViewModel likedSongViewModel);

        void DeleteLikedSongBySongId(Guid songId);

        List<ILikedSongViewModel> GetLikedSongsByUserId(Guid userId);
    }
}
