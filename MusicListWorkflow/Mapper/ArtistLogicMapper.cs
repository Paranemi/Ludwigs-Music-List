﻿using DomainModels;
using DomainModels.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using ViewModels;
using ViewModels.Contracts;

namespace MusicListWorkflow.Mapper
{
    public class ArtistLogicMapper : IArtistLogicMapper
    {

        public IArtistDomainModel ToDomainModel(IArtistViewModel viewModel)
        {
            var domainModel = new ArtistDomainModel();
            domainModel.ArtistId = viewModel.ArtistId;
            domainModel.Name = viewModel.Name;
            domainModel.ArtistImageUrl = viewModel.ArtistImageUrl;
            domainModel.Founded = viewModel.Founded;
            return domainModel;
        }
        public IArtistViewModel ToViewModel(IArtistDomainModel domainModel)
        {
            var viewModel = new ArtistViewModel();
            viewModel.ArtistId = domainModel.ArtistId;
            viewModel.Name = domainModel.Name;
            viewModel.ArtistImageUrl = domainModel.ArtistImageUrl;
            viewModel.Founded = domainModel.Founded;
            return viewModel;
        }
    }
}
