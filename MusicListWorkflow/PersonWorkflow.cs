using MusicListWorkflow.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.Contracts;

namespace MusicListWorkflow
{
    public class PersonWorkflow : IPersonWorkflow
    {
        private readonly IPersonLogicMapper _personLogicMapper;
        private readonly IPersonRepository _personRepository;

        public PersonWorkflow(IPersonLogicMapper personLogicMapper, IPersonRepository personRepository)
        {
            _personLogicMapper = personLogicMapper;
            _personRepository = personRepository;
        }
        //obacht test
        public void CreatePerson(IPersonViewModel personViewModel, Guid artistId)
        {
            var domainModel = _personLogicMapper.ToDomainModel(personViewModel);
            _personRepository.CreatePerson(domainModel, artistId);
        }

        public IPersonViewModel GetPersonByArtistId(Guid artistId)
        {
            var domainModel = _personRepository.GetPersonByArtistId(artistId);
            return _personLogicMapper.ToViewModel(domainModel);
        }

        public void UpdatePersonById(Guid personId)
        {
            throw new NotImplementedException();
        }
    }
}
