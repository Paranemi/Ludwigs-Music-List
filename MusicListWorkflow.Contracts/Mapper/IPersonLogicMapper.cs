using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;
using ViewModels.Contracts;

namespace MusicListWorkflow.Contracts.Mapper
{
    public interface IPersonLogicMapper
    {
        IPersonDomainModel ToDomainModel(IPersonViewModel viewModel);

        IPersonViewModel ToViewModel(IPersonDomainModel domainModel);
    }
}
