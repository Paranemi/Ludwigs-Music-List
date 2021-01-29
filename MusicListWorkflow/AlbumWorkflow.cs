using MusicListWorkflow.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using System;
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
            var domainModel = _albumRepository.GetAlbumByName(albumName);
            return _albumLogicMapper.ToViewModel(domainModel);
        }

        public void UpdateAlbumById(Guid albumId)
        {
            throw new NotImplementedException();
        }
    }
}
