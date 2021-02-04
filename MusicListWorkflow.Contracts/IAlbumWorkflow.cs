using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using ViewModels.Contracts;

namespace MusicListWorkflow.Contracts
{
    public interface IAlbumWorkflow
    {
        void CreateAlbum(IAlbumViewModel albumViewModel);

        IAlbumViewModel GetAlbumById(Guid albumId);

        IAlbumViewModel GetAlbumByName(string albumName);

        List<IAlbumViewModel> GetAllAlbums();

        Guid GetAlbumIdByName(string albumName);

        void UpdateAlbumById(Guid albumId);

        void DeleteAlbumById(Guid albumId);
    }
}
