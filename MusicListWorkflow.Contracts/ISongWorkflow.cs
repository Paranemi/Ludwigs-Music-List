using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.Contracts;

namespace MusicListWorkflow.Contracts
{
    public interface ISongWorkflow
    {

        void CreateSong(ISongViewModel songViewModel, Guid albumId, Guid artistId);

        ISongViewModel GetSongById(Guid songId);

        ISongViewModel GetSongByName(string songName);

        List<ISongViewModel> GetAllSongs();

        void UpdateSong(ISongViewModel songViewModel);

        void DeleteSongById(Guid songId);
    }
}
