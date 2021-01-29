using DomainModels;
using DomainModels.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using ViewModels;
using ViewModels.Contracts;

namespace MusicListWorkflow.Mapper
{
    public class SongLogicMapper : ISongLogicMapper
    {
        private readonly IAlbumLogicMapper _albumLogicMapper;
        private readonly IArtistLogicMapper _artistLogicMapper;
        private readonly ILikedSongLogicMapper _likedSongLogicMapper;

        public SongLogicMapper(IAlbumLogicMapper albumLogicMapper, IArtistLogicMapper artistLogicMapper, ILikedSongLogicMapper likedSongLogicMapper)
        {
            _albumLogicMapper = albumLogicMapper;
            _artistLogicMapper = artistLogicMapper;
            _likedSongLogicMapper = likedSongLogicMapper;
        }

        public ISongDomainModel ToDomainModel(ISongViewModel viewModel)
        {
            var domainModel = new SongDomainModel();
            domainModel.Album = _albumLogicMapper.ToDomainModel(viewModel.Album);
            domainModel.AlbumId = viewModel.AlbumId;
            domainModel.Artist = _artistLogicMapper.ToDomainModel(viewModel.Artist);
            domainModel.ArtistId = viewModel.ArtistId;
            domainModel.LinkSptfy = viewModel.LinkSptfy;
            domainModel.LinkYT = viewModel.LinkYT;
            domainModel.Name = viewModel.Name;
            domainModel.SongId = viewModel.SongId;
            return domainModel;
        }

        public ISongViewModel ToViewModel(ISongDomainModel domainModel)
        {
            var viewModel = new SongViewModel();
            viewModel.Album = _albumLogicMapper.ToViewModel(domainModel.Album);
            viewModel.AlbumId = domainModel.AlbumId;
            viewModel.Artist = _artistLogicMapper.ToViewModel(domainModel.Artist);
            viewModel.ArtistId = domainModel.ArtistId;
            viewModel.LinkSptfy = domainModel.LinkSptfy;
            viewModel.LinkYT = domainModel.LinkYT;
            viewModel.Name = domainModel.Name;
            viewModel.SongId = domainModel.SongId;
            return viewModel;
        }
    }
}
