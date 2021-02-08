using MusicListWorkflow.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using System;
using System.Collections.Generic;
using ViewModels.Contracts;

namespace MusicListWorkflow
{
    public class AlbumWorkflow : IAlbumWorkflow
    {
        private readonly IAlbumLogicMapper _albumLogicMapper;
        private readonly IAlbumRepository _albumRepository;

        public AlbumWorkflow(IAlbumLogicMapper albumLogicMapper, IAlbumRepository albumRepository)
        {
            _albumLogicMapper = albumLogicMapper;
            _albumRepository = albumRepository;
        }

        public void CreateAlbum(IAlbumViewModel albumViewModel)
        {
            var domainModel = _albumLogicMapper.ToDomainModel(albumViewModel);
            _albumRepository.CreateAlbum(domainModel);
        }

        public void DeleteAlbumById(Guid albumId)
        {
            _albumRepository.DeleteAlbumById(albumId);
        }

        public IAlbumViewModel GetAlbumById(Guid albumId)
        {
            var domainModel = _albumRepository.GetAlbumById(albumId);
            return _albumLogicMapper.ToViewModel(domainModel);
        }

        public IAlbumViewModel GetAlbumByName(string albumName)
        {
            try
            {
                var domainModel = _albumRepository.GetAlbumByName(albumName);
                return _albumLogicMapper.ToViewModel(domainModel);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Guid GetAlbumIdByName(string albumName)
        {
            return _albumRepository.GetAlbumIdByName(albumName);
        }

        public List<IAlbumViewModel> GetAllAlbums()
        {
            List<IAlbumViewModel> listViewModel = new List<IAlbumViewModel>();
            var allElementsDomainModel = _albumRepository.GetAllAlbums();

            foreach (var item in allElementsDomainModel)
            {
                listViewModel.Add(_albumLogicMapper.ToViewModel(item));
            }

            return listViewModel;
        }

        public void UpdateAlbumById(Guid albumId)
        {
            throw new NotImplementedException();
        }
    }
}
