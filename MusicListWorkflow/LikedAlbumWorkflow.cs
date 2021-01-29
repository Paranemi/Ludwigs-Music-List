using MusicListWorkflow.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.Contracts;

namespace MusicListWorkflow.Mapper
{
    public class LikedAlbumWorkflow : ILikedAlbumWorkflow
    {
        private readonly ILikedAlbumLogicMapper _likedAlbumLogicMapper;
        private readonly ILikedAlbumRepository _likedAlbumRepository;

        public LikedAlbumWorkflow(ILikedAlbumLogicMapper likedAlbumLogicMapper, ILikedAlbumRepository likedAlbumRepository)
        {
            _likedAlbumLogicMapper = likedAlbumLogicMapper;
            _likedAlbumRepository = likedAlbumRepository;
        }

        public void CreateLikedAlbum(ILikedAlbumViewModel likedAlbumViewModel)
        {
            var domainModel = _likedAlbumLogicMapper.ToDomainModel(likedAlbumViewModel);
            _likedAlbumRepository.CreateLikedAlbum(domainModel);
        }

        public void DeleteLikedAlbumById(Guid likedAlbumId)
        {
            _likedAlbumRepository.DeleteLikedAlbumById(likedAlbumId);
        }
    }
}
