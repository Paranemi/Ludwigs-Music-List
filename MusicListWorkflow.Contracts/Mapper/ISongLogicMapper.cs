using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;
using ViewModels.Contracts;

namespace MusicListWorkflow.Contracts.Mapper
{
    public interface ISongLogicMapper
    {
        ISongDomainModel ToDomainModel(ISongViewModel viewModel);

        ISongViewModel ToViewModel(ISongDomainModel domainModel);
    }
}
