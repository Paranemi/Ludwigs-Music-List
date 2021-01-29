using DomainModels;
using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using EntityFrameworkRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRepository.Mapper
{
    public class ArtistDataMapper : IArtistDataMapper
    {

        public IArtistDomainModel ToDomainModel(ArtistEntityModel entityModel)
        {
            var domainModel = new ArtistDomainModel();
            domainModel.ArtistId = entityModel.ArtistId;
            domainModel.Name = entityModel.Name;
            domainModel.ArtistImageUrl = entityModel.ArtistImageUrl;
            domainModel.Founded = entityModel.Founded;
            return domainModel;
        }
        public ArtistEntityModel ToEntityModel(IArtistDomainModel domainModel)
        {
            var entityModel = new ArtistEntityModel();
            entityModel.ArtistId = domainModel.ArtistId;
            entityModel.Name = domainModel.Name;
            entityModel.ArtistImageUrl = domainModel.ArtistImageUrl;
            entityModel.Founded = domainModel.Founded;
            return entityModel;
        }
    }
}
