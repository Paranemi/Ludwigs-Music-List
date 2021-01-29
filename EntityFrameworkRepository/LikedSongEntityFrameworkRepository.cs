using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using EntityFrameworkRepository.Interfaces;
using EntityFrameworkRepository.Mapper;
using MusicListWorkflow.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkRepository
{
    public class LikedSongEntityFrameworkRepository : ILikedSongRepository
    {

        private readonly AppDataContext _context;
        private readonly ILikedSongDataMapper _likedSongDataMapper;

        public LikedSongEntityFrameworkRepository(AppDataContext context, ILikedSongDataMapper likedSongDataMapper)
        {
            _context = context;
            _likedSongDataMapper = likedSongDataMapper;
        }

        public void CreateLikedSong(ILikedSongDomainModel likedSongDomainModel)
        {
            var likedSongEntityModel = _likedSongDataMapper.ToEntityModel(likedSongDomainModel);
            var existingSongEntityModel = _context.Song.Single(s => s.SongId == likedSongEntityModel.Song.SongId);
            likedSongEntityModel.Song = existingSongEntityModel;

            var existingUserEntityModel = _context.User.Single(s => s.UserId == likedSongEntityModel.User.UserId);
            likedSongEntityModel.User = existingUserEntityModel;



            _context.Add(likedSongEntityModel);

            _context.SaveChanges();
        }

        public void DeleteLikedSongById(Guid likedSongId)
        {
            var likedSong = new LikedSongEntityModel
            {
                LikedSongId = likedSongId
            };
            _context.Remove(likedSong);
            _context.SaveChanges();
        }


    }
}
