using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicListWorkflow.Contracts
{
    public interface IPersonRepository
    {
        void CreatePerson(IPersonDomainModel personDomainModel, Guid artistId);

        List<IPersonDomainModel> GetPersonByArtistId(Guid artistId);

        void UpdatePersonById(Guid personId);

    }
}
