using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicListWorkflow.Contracts
{
    public interface IArtistRepository
    {
        void CreateArtist(IArtistDomainModel artistDomainModel);

        IArtistDomainModel GetArtistById(Guid artistId);

        IArtistDomainModel GetArtistByName(string artistName);

        List<IArtistDomainModel> GetAllArtists();

        void UpdateArtist(IArtistDomainModel artistDomainModel);

        Guid GetArtistIdByName(string artistName);

        void DeleteArtistById(Guid artistId);
    }
}
