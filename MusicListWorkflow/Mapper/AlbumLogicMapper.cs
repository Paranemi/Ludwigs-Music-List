using DomainModels;
using DomainModels.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using ViewModels;
using ViewModels.Contracts;

namespace MusicListWorkflow.Mapper
{
    public class AlbumLogicMapper : IAlbumLogicMapper
    {

        private readonly ILikedAlbumLogicMapper _likedAlbumLogicMapper;
        private readonly ISongLogicMapper _songLogicMapper;

        public AlbumLogicMapper(ILikedAlbumLogicMapper likedAlbumLogicMapper, ISongLogicMapper songLogicMapper)
        {
            _likedAlbumLogicMapper = likedAlbumLogicMapper;
            _songLogicMapper = songLogicMapper;
        }

        public IAlbumDomainModel ToDomainModel(IAlbumViewModel viewModel)
        {
            var domainModel = new AlbumDomainModel();
            domainModel.Name = viewModel.Name;
            domainModel.AlbumId = viewModel.AlbumId;
            domainModel.ImageUrl = viewModel.ImageUrl;
            domainModel.ReleaseDate = viewModel.ReleaseDate;
            return domainModel;
        }
        public IAlbumViewModel ToViewModel(IAlbumDomainModel domainModel)
        {
            var viewModel = new AlbumViewModel();
            viewModel.Name = domainModel.Name;
            viewModel.AlbumId = domainModel.AlbumId;
            viewModel.ImageUrl = domainModel.ImageUrl;
            viewModel.ReleaseDate = domainModel.ReleaseDate;
            return viewModel;
        }
    }
}
