using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicListWorkflow.Contracts
{
    public interface IAlbumRepository
    {
        void CreateAlbum(IAlbumDomainModel albumDomainModel);

        IAlbumDomainModel GetAlbumById(Guid albumId);

        IAlbumDomainModel GetAlbumByName(string albumName);

        Guid GetAlbumIdByName(string albumName);

        void UpdateAlbumById(Guid albumId);

        void DeleteAlbumById(Guid albumId);
    }
}
