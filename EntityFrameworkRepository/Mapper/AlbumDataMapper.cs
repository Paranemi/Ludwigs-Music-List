using DomainModels;
using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using EntityFrameworkRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRepository.Mapper
{
    public class AlbumDataMapper : IAlbumDataMapper
    {

        public IAlbumDomainModel ToDomainModel(AlbumEntityModel entityModel)
        {
            var domainModel = new AlbumDomainModel();
            domainModel.Name = entityModel.Name;
            domainModel.AlbumId = entityModel.AlbumId;
            domainModel.ImageUrl = entityModel.ImageUrl;
            domainModel.ReleaseDate = entityModel.ReleaseDate;
            return domainModel;
        }
        public AlbumEntityModel ToEntityModel(IAlbumDomainModel domainModel)
        {
            var entityModel = new AlbumEntityModel();
            entityModel.Name = domainModel.Name;
            entityModel.AlbumId = domainModel.AlbumId;
            entityModel.ImageUrl = domainModel.ImageUrl;
            entityModel.ReleaseDate = domainModel.ReleaseDate;
            return entityModel;
        }
    }
}
