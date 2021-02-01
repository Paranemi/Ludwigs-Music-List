using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicListWorkflow.Contracts
{
    public interface ILikedSongRepository
    {
        void CreateLikedSong(ILikedSongDomainModel likedSongDomainModel);

        void DeleteLikedSongById(Guid likedSongId);

        List<ILikedSongDomainModel> GetLikedSongsByUserId(Guid userId);
    }
}
