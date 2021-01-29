using DomainModels;
using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using EntityFrameworkRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRepository.Mapper
{
    public class LikedSongDataMapper : ILikedSongDataMapper
    {
        private readonly ISongDataMapper _songDataMapper;
        private readonly IUserDataMapper _userDataMapper;

        public LikedSongDataMapper(ISongDataMapper songDataMapper, IUserDataMapper userDataMapper)
        {
            _songDataMapper = songDataMapper;
            _userDataMapper = userDataMapper;
        }

        public ILikedSongDomainModel ToDomainModel(LikedSongEntityModel entityModel)
        {
            var domainModel = new LikedSongDomainModel();
            domainModel.LikedSongId = entityModel.LikedSongId;
            domainModel.SongId = entityModel.SongId;
            domainModel.Song = _songDataMapper.ToDomainModel(entityModel.Song);
            domainModel.UserId = entityModel.UserId;
            domainModel.User = _userDataMapper.ToDomainModel(entityModel.User);
            return domainModel;
        }
        
        public LikedSongEntityModel ToEntityModel(ILikedSongDomainModel domainModel)
        {
            var entityModel = new LikedSongEntityModel();
            entityModel.LikedSongId = domainModel.LikedSongId;
            entityModel.SongId = domainModel.SongId;
            entityModel.Song = _songDataMapper.ToEntityModel(domainModel.Song);
            entityModel.UserId = domainModel.UserId;
            entityModel.User = _userDataMapper.ToEntityModel(domainModel.User);
            return entityModel;
        }
    }
}
