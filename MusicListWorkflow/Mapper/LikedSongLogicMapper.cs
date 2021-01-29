using DomainModels;
using DomainModels.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using ViewModels;
using ViewModels.Contracts;

namespace MusicListWorkflow.Mapper
{
    public class LikedSongLogicMapper : ILikedSongLogicMapper
    {
        private readonly ISongLogicMapper _songLogicMapper;
        private readonly IUserLogicMapper _userLogicMapper;

        public LikedSongLogicMapper(ISongLogicMapper songLogicMapper, IUserLogicMapper userLogicMapper)
        {
            _songLogicMapper = songLogicMapper;
            _userLogicMapper = userLogicMapper;
        }

        public ILikedSongDomainModel ToDomainModel(ILikedSongViewModel viewModel)
        {
            var domainModel = new LikedSongDomainModel();
            domainModel.LikedSongId = viewModel.LikedSongId;
            domainModel.SongId = viewModel.SongId;
            domainModel.Songs = _songLogicMapper.ToDomainModel(viewModel.Songs);
            domainModel.UserId = viewModel.UserId;
            domainModel.User = _userLogicMapper.ToDomainModel(viewModel.User);
            return domainModel;
        }

        public ILikedSongViewModel ToViewModel(ILikedSongDomainModel domainModel)
        {
            var viewModel = new LikedSongViewModel();
            viewModel.LikedSongId = domainModel.LikedSongId;
            viewModel.SongId = domainModel.SongId;
            viewModel.Songs = _songLogicMapper.ToViewModel(domainModel.Songs);
            viewModel.UserId = domainModel.UserId;
            viewModel.User = _userLogicMapper.ToViewModel(domainModel.User);
            return viewModel;
        }
    }
}
