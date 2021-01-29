using DomainModels;
using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using EntityFrameworkRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRepository.Mapper
{
    public class SongDataMapper : ISongDataMapper
    {
        private readonly IAlbumDataMapper _albumDataMapper;
        private readonly IArtistDataMapper _artistDataMapper;

        public SongDataMapper(IAlbumDataMapper albumDataMapper, IArtistDataMapper artistDataMapper)
        {
            _albumDataMapper = albumDataMapper;
            _artistDataMapper = artistDataMapper;
        }

        public ISongDomainModel ToDomainModel(SongEntityModel entityModel)
        {
            var domainModel = new SongDomainModel();
            domainModel.Album = _albumDataMapper.ToDomainModel(entityModel.Album);
            domainModel.AlbumId = entityModel.AlbumId;
            domainModel.Artist = _artistDataMapper.ToDomainModel(entityModel.Artist);
            domainModel.ArtistId = entityModel.ArtistId;
            domainModel.LinkSptfy = entityModel.LinkSptfy;
            domainModel.LinkYT = entityModel.LinkYT;
            domainModel.Name = entityModel.Name;
            domainModel.SongId = entityModel.SongId;
            return domainModel;
        }

        public SongEntityModel ToEntityModel(ISongDomainModel domainModel)
        {
            var entityModel = new SongEntityModel();
            entityModel.Album = _albumDataMapper.ToEntityModel(domainModel.Album);
            entityModel.AlbumId = domainModel.AlbumId;
            entityModel.Artist = _artistDataMapper.ToEntityModel(domainModel.Artist);
            entityModel.ArtistId = domainModel.ArtistId;
            entityModel.LinkSptfy = domainModel.LinkSptfy;
            entityModel.LinkYT = domainModel.LinkYT;
            entityModel.Name = domainModel.Name;
            entityModel.SongId = domainModel.SongId;
            return entityModel;
        }
    }
}
