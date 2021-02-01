using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.Contracts;

namespace MusicListWorkflow.Contracts
{
    public interface IPersonWorkflow
    {
        void CreatePerson(IPersonViewModel personViewModel, Guid artistId);

        List<IPersonViewModel> GetPersonByArtistId(Guid artistId);

        void UpdatePersonById(Guid personId);

    }
}
