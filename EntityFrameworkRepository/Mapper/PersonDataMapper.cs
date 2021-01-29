using DomainModels;
using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using EntityFrameworkRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRepository.Mapper
{
    public class PersonDataMapper : IPersonDataMapper
    {
        private readonly IArtistDataMapper _artistDataMapper;

        public PersonDataMapper(IArtistDataMapper artistDataMapper)
        {
            _artistDataMapper = artistDataMapper;
        }

        public IPersonDomainModel ToDomainModel(PersonEntityModel entityModel)
        {
            var domainModel = new PersonDomainModel();
            domainModel.PersonId = entityModel.PersonId;
            domainModel.FirstName = entityModel.FirstName;
            domainModel.LastName = entityModel.LastName;
            domainModel.From = entityModel.From;
            domainModel.To = entityModel.To;
            domainModel.Born = entityModel.Born;
            domainModel.Died = entityModel.Died;
            domainModel.ImageUrl = entityModel.ImageUrl;
            domainModel.ArtistId = entityModel.ArtistId;
            domainModel.Artist = _artistDataMapper.ToDomainModel(entityModel.Artist);
            return domainModel;
        }
        public PersonEntityModel ToEntityModel(IPersonDomainModel domainModel)
        {
            var entityModel = new PersonEntityModel();
            entityModel.PersonId = domainModel.PersonId;
            entityModel.FirstName = domainModel.FirstName;
            entityModel.LastName = domainModel.LastName;
            entityModel.From = domainModel.From;
            entityModel.To = domainModel.To;
            entityModel.Born = domainModel.Born;
            entityModel.Died = domainModel.Died;
            entityModel.ImageUrl = domainModel.ImageUrl;
            entityModel.ArtistId = domainModel.ArtistId;
            entityModel.Artist = _artistDataMapper.ToEntityModel(domainModel.Artist);
            return entityModel;
        }
    }
}
