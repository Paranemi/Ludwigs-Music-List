using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;
using ViewModels.Contracts;

namespace MusicListWorkflow.Contracts.Mapper
{
    public interface ILikedAlbumLogicMapper
    {
        ILikedAlbumDomainModel ToDomainModel(ILikedAlbumViewModel viewModel);

        ILikedAlbumViewModel ToViewModel(ILikedAlbumDomainModel domainModel);

    }
}
