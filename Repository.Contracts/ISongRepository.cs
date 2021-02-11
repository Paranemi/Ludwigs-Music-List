using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicListWorkflow.Contracts
{
    public interface ISongRepository
    {

        void CreateSong(ISongDomainModel songDomainModel, Guid albumId, Guid artistId);

        ISongDomainModel GetSongById(Guid songId);

        ISongDomainModel GetSongByName(string songName);

        List<ISongDomainModel> GetAllSongs();

        void UpdateSong(ISongDomainModel songDomainModel);

        void DeleteSongById(Guid songId);
    }
}
