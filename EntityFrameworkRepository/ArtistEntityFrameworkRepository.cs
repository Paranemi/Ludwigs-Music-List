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
    public class ArtistEntityFrameworkRepository : IArtistRepository
    {

        private readonly AppDataContext _context;
        private readonly IArtistDataMapper _artistDataMapper;

        public ArtistEntityFrameworkRepository(AppDataContext context, IArtistDataMapper artistDataMapper)
        {
            _context = context;
            _artistDataMapper = artistDataMapper;
        }

        public void CreateArtist(IArtistDomainModel artistDomainModel)
        {
            var artistEntityModel = _artistDataMapper.ToEntityModel(artistDomainModel);
            var artist = new ArtistEntityModel
            {
                Name = artistEntityModel.Name,
                ArtistImageUrl = artistEntityModel.ArtistImageUrl,
                Founded = artistEntityModel.Founded
                
            };
            _context.Artist.Add(artist);
            _context.SaveChanges();
        }

        public void DeleteArtistById(Guid artistId)
        {
            var artist = new ArtistEntityModel
            {
                ArtistId = artistId
            };
            _context.Artist.Remove(artist);
            _context.SaveChanges();
        }

        public IArtistDomainModel GetArtistById(Guid artistId)
        {
            return _artistDataMapper.ToDomainModel(_context.Artist.Single(b => b.ArtistId == artistId));
        }

        public IArtistDomainModel GetArtistByName(string artistName)
        {
            return _artistDataMapper.ToDomainModel(_context.Artist.Single(b => b.Name.Contains(artistName)));
        }

        public List<IArtistDomainModel> GetAllArtists()
        {
            List<IArtistDomainModel> listDomainModel = new List<IArtistDomainModel>();
            List<ArtistEntityModel> allElementsEntityModel;
            allElementsEntityModel = _context.Artist.ToList();

            foreach (var item in allElementsEntityModel)
            {
                listDomainModel.Add(_artistDataMapper.ToDomainModel(item));
            }

            return listDomainModel;
        }

        public Guid GetArtistIdByName(string artistName)
        {
            var artist = _context.Artist.Single(b => b.Name.Contains(artistName));
            Guid SelectedArtistArtistId = artist.ArtistId;
            return SelectedArtistArtistId;
        }

        public void UpdateArtist(IArtistDomainModel artistDomainModel)
        {
            var artistEntityModel = _artistDataMapper.ToEntityModel(artistDomainModel);
            _context.Update(artistEntityModel);
            _context.SaveChanges();
        }
    }
}
