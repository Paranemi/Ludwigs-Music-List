using DomainModels;
using DomainModels.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using ViewModels;
using ViewModels.Contracts;

namespace MusicListWorkflow.Mapper
{
    public class LikedAlbumLogicMapper : ILikedAlbumLogicMapper
    {
        private readonly IAlbumLogicMapper _albumLogicMapper;
        private readonly IUserLogicMapper _userLogicMapper;

        public LikedAlbumLogicMapper(IAlbumLogicMapper albumLogicMapper, IUserLogicMapper userLogicMapper)
        {
            _albumLogicMapper = albumLogicMapper;
            _userLogicMapper = userLogicMapper;
        }

        public ILikedAlbumDomainModel ToDomainModel(ILikedAlbumViewModel viewModel)
        {
            var domainModel = new LikedAlbumDomainModel();
            domainModel.Album = _albumLogicMapper.ToDomainModel(viewModel.Album);
            domainModel.AlbumId = viewModel.AlbumId;
            domainModel.LikedAlbumId = viewModel.LikedAlbumId;
            domainModel.User = _userLogicMapper.ToDomainModel(viewModel.User);
            domainModel.UserId = viewModel.UserId;
            return domainModel;
        }

        public ILikedAlbumViewModel ToViewModel(ILikedAlbumDomainModel domainModel)
        {
            var viewModel = new LikedAlbumViewModel();
            viewModel.Album = _albumLogicMapper.ToViewModel(domainModel.Album);
            viewModel.AlbumId = domainModel.AlbumId;
            viewModel.LikedAlbumId = domainModel.LikedAlbumId;
            viewModel.User = _userLogicMapper.ToViewModel(domainModel.User);
            viewModel.UserId = domainModel.UserId;
            return viewModel;
        }
    }
}
