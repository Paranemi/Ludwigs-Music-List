using DomainModels;
using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using EntityFrameworkRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRepository.Mapper
{
    public class LikedAlbumDataMapper : ILikedAlbumDataMapper
    {
        private readonly IAlbumDataMapper _albumDataMapper;
        private readonly IUserDataMapper _userDataMapper;

        public LikedAlbumDataMapper(IAlbumDataMapper albumDataMapper, IUserDataMapper userDataMapper)
        {
            _albumDataMapper = albumDataMapper;
            _userDataMapper = userDataMapper;
        }

        public ILikedAlbumDomainModel ToDomainModel(LikedAlbumEntityModel entityModel)
        {
            var domainModel = new LikedAlbumDomainModel();
            domainModel.Album = _albumDataMapper.ToDomainModel(entityModel.Album);
            domainModel.AlbumId = entityModel.AlbumId;
            domainModel.LikedAlbumId = entityModel.LikedAlbumId;
            domainModel.User = _userDataMapper.ToDomainModel(entityModel.User);
            domainModel.UserId = entityModel.UserId;
            return domainModel;
        }

        public LikedAlbumEntityModel ToEntityModel(ILikedAlbumDomainModel domainModel)
        {
            var entityModel = new LikedAlbumEntityModel();
            entityModel.Album = _albumDataMapper.ToEntityModel(domainModel.Album);
            entityModel.AlbumId = domainModel.AlbumId;
            entityModel.LikedAlbumId = domainModel.LikedAlbumId;
            entityModel.User = _userDataMapper.ToEntityModel(domainModel.User);
            entityModel.UserId = domainModel.UserId;
            return entityModel;
        }
    }
}
