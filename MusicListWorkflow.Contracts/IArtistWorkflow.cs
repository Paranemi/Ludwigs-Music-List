using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.Contracts;

namespace MusicListWorkflow.Contracts
{
    public interface IArtistWorkflow
    {
        void CreateArtist(IArtistViewModel artistViewModel);

        IArtistViewModel GetArtistById(Guid artistId);

        IArtistViewModel GetArtistByName(string artistName);

        void UpdateArtist(IArtistViewModel artistViewModel);

        void DeleteArtistById(Guid artistId);
    }
}
