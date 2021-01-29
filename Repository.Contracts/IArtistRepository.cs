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

        void UpdateArtist(IArtistDomainModel artistDomainModel);

        void DeleteArtistById(Guid artistId);
    }
}
