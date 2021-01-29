using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using EntityFrameworkRepository.Interfaces;
using EntityFrameworkRepository.Mapper;
using MusicListWorkflow.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkRepository
{
    public class PersonEntityFrameworkRepository : IPersonRepository
    {

        private readonly AppDataContext _context;
        private readonly IPersonDataMapper _personDataMapper;

        public PersonEntityFrameworkRepository(AppDataContext context, IPersonDataMapper personDataMapper)
        {
            _context = context;
            _personDataMapper = personDataMapper;
        }

        public void CreatePerson(IPersonDomainModel personDomainModel, Guid artistId)
        {
            var personEntityModel = _personDataMapper.ToEntityModel(personDomainModel);
            var person = new PersonEntityModel
            {    
                From = personEntityModel.From,
                To = personEntityModel.To,
                FirstName = personEntityModel.FirstName,
                LastName = personEntityModel.LastName,
                ImageUrl = personEntityModel.ImageUrl,
                Born = personEntityModel.Born,
                Died = personEntityModel.Died,
                ArtistId = artistId                
                
            };
            _context.Person.Add(person);
            _context.SaveChanges();
        }

        public IPersonDomainModel GetPersonByArtistId(Guid artistId)
        {
            return _personDataMapper.ToDomainModel(_context.Person.Single(b => b.ArtistId == artistId));
        }

        public void UpdatePersonById(Guid personId)
        {
            throw new NotImplementedException();
        }
    }
}
