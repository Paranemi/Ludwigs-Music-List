using DomainModels;
using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;
using ViewModels.Contracts;

namespace MusicListWorkflow.Contracts.Mapper
{
    public interface ILikedSongLogicMapper
    {
        ILikedSongDomainModel ToDomainModel(ILikedSongViewModel viewModel);

        ILikedSongViewModel ToViewModel(ILikedSongDomainModel domainModel);
    }
}
