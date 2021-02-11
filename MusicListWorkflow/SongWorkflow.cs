using MusicListWorkflow.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.Contracts;

namespace MusicListWorkflow
{
    public class SongWorkflow : ISongWorkflow
    {
        private readonly ISongLogicMapper _songLogicMapper;
        private readonly ISongRepository _songRepository;

        public SongWorkflow(ISongLogicMapper songLogicMapper, ISongRepository songRepository)
        {
            _songLogicMapper = songLogicMapper;
            _songRepository = songRepository;
        }

        public void CreateSong(ISongViewModel songViewModel, Guid albumId, Guid artistId)
        {
            var domainModel = _songLogicMapper.ToDomainModel(songViewModel);
            _songRepository.CreateSong(domainModel, albumId, artistId);
        }

        public void DeleteSongById(Guid songId)
        {
            _songRepository.DeleteSongById(songId);
        }

        public ISongViewModel GetSongById(Guid songId)
        {
            var domainModel = _songRepository.GetSongById(songId);
            return _songLogicMapper.ToViewModel(domainModel);
        }

        public ISongViewModel GetSongByName(string songName)
        {
            var domainModel = _songRepository.GetSongByName(songName);
            return _songLogicMapper.ToViewModel(domainModel);
        }

        public List<ISongViewModel> GetAllSongs()
        {
            List <ISongViewModel> listViewModel = new List<ISongViewModel>();
            var allElementsDomainModel = _songRepository.GetAllSongs();

            foreach (var item in allElementsDomainModel)
            {
                listViewModel.Add(_songLogicMapper.ToViewModel(item));
            }

            return listViewModel;
        }

        public void UpdateSong(ISongViewModel songViewModel)
        {
            var domainModel = _songLogicMapper.ToDomainModel(songViewModel);
            _songRepository.UpdateSong(domainModel);
        }

    }
}
