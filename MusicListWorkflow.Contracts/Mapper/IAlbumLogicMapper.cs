using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;
using ViewModels.Contracts;

namespace MusicListWorkflow.Contracts.Mapper
{
    public interface IAlbumLogicMapper
    {
        IAlbumDomainModel ToDomainModel(IAlbumViewModel viewModel);

        IAlbumViewModel ToViewModel(IAlbumDomainModel domainModel);
    }
}
