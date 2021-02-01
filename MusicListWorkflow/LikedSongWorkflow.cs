using MusicListWorkflow.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.Contracts;

namespace MusicListWorkflow
{
    public class LikedSongWorkflow : ILikedSongWorkflow
    {
        private readonly ILikedSongLogicMapper _likedSongLogicMapper;
        private readonly ILikedSongRepository _likedSongRepository;

        public LikedSongWorkflow(ILikedSongLogicMapper likedSongLogicMapper, ILikedSongRepository likedSongRepository)
        {
            _likedSongLogicMapper = likedSongLogicMapper;
            _likedSongRepository = likedSongRepository;
        }

        public void CreateLikedSong(ILikedSongViewModel likedSongViewModel)
        {
            var domainModel = _likedSongLogicMapper.ToDomainModel(likedSongViewModel);
            _likedSongRepository.CreateLikedSong(domainModel);
        }

        public void DeleteLikedSongById(Guid likedSongId)
        {
            _likedSongRepository.DeleteLikedSongById(likedSongId);
        }

        public List<ILikedSongViewModel> GetLikedSongsByUserId(Guid userId)
        {
            List<ILikedSongViewModel> listViewModel = new List<ILikedSongViewModel>();
            var allElementsDomainModel = _likedSongRepository.GetLikedSongsByUserId(userId);

            foreach (var item in allElementsDomainModel)
            {
                listViewModel.Add(_likedSongLogicMapper.ToViewModel(item));
            }

            return listViewModel;
        }
    }
}
