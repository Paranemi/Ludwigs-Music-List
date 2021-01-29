using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;
using ViewModels.Contracts;

namespace MusicListWorkflow.Contracts.Mapper
{
    public interface IArtistLogicMapper
    {
        IArtistDomainModel ToDomainModel(IArtistViewModel viewModel);

        IArtistViewModel ToViewModel(IArtistDomainModel domainModel);
    }
}
