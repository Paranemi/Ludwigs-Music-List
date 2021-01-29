using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using EntityFrameworkRepository.Interfaces;
using EntityFrameworkRepository.Mapper;
using MusicListWorkflow.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRepository
{
    public class LikedAlbumEntityFrameworkRepository : ILikedAlbumRepository
    {

        private readonly AppDataContext _context;
        private readonly ILikedAlbumDataMapper _likedAlbumDataMapper;

        public LikedAlbumEntityFrameworkRepository(AppDataContext context, ILikedAlbumDataMapper likedAlbumDataMapper)
        {
            _context = context;
            _likedAlbumDataMapper = likedAlbumDataMapper;
        }

        public void CreateLikedAlbum(ILikedAlbumDomainModel likedAlbumDomainModel)
        {
            var likedAlbumEntityModel = _likedAlbumDataMapper.ToEntityModel(likedAlbumDomainModel);
            var likedAlbum = new LikedAlbumEntityModel
            {
                AlbumId = likedAlbumEntityModel.AlbumId,
                UserId = likedAlbumEntityModel.UserId
            };
            _context.Add(likedAlbum);
            _context.SaveChanges();

        }

        public void DeleteLikedAlbumById(Guid likedAlbumId)
        {
            var likedAlbum = new LikedAlbumEntityModel
            {
                LikedAlbumId = likedAlbumId
            };
            _context.LikedAlbum.Remove(likedAlbum);
            _context.SaveChanges();
        }

    }
}
