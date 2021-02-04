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
    public class AlbumEntityFrameworkRepository : IAlbumRepository
    {

        private readonly AppDataContext _context;
        private readonly IAlbumDataMapper _albumDataMapper;

        public AlbumEntityFrameworkRepository(AppDataContext context, IAlbumDataMapper albumDataMapper)
        {
            _context = context;
            _albumDataMapper = albumDataMapper;
        }

        public void CreateAlbum(IAlbumDomainModel albumDomainModel)
        {
            var albumEntityModel = _albumDataMapper.ToEntityModel(albumDomainModel);
            var album = new AlbumEntityModel
            {
                Name = albumEntityModel.Name,
                ImageUrl = albumEntityModel.ImageUrl,
                ReleaseDate = albumEntityModel.ReleaseDate
            };
            _context.Album.Add(album);
            _context.SaveChanges();
        }

        public void DeleteAlbumById(Guid albumId)
        {
            var album = new AlbumEntityModel
            {
                AlbumId = albumId
            };
            _context.Album.Remove(album);
            _context.SaveChanges();
        }

        public IAlbumDomainModel GetAlbumById(Guid albumId)
        {
            return _albumDataMapper.ToDomainModel(_context.Album.Single(b => b.AlbumId == albumId));
        }

        public IAlbumDomainModel GetAlbumByName(string albumName)
        {
            return _albumDataMapper.ToDomainModel(_context.Album.Single(b => b.Name.Contains(albumName)));
        }

        public Guid GetAlbumIdByName(string albumName)
        {
            var album = _context.Album.Single(b => b.Name.Contains(albumName));
            Guid SelectedAlbumAlbumId = album.AlbumId;
            return SelectedAlbumAlbumId;
        }

        public List<IAlbumDomainModel> GetAllAlbums()
        {
            List<IAlbumDomainModel> listDomainModel = new List<IAlbumDomainModel>();
            List<AlbumEntityModel> allElementsEntityModel;
            allElementsEntityModel = _context.Album.ToList();

            foreach (var item in allElementsEntityModel)
            {
                listDomainModel.Add(_albumDataMapper.ToDomainModel(item));
            }

            return listDomainModel;
        }

        public void UpdateAlbumById(Guid albumId)
        {
            throw new NotImplementedException();
        }
    }
}
