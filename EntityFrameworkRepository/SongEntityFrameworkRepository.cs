﻿using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using EntityFrameworkRepository.Interfaces;
using EntityFrameworkRepository.Mapper;
using MusicListWorkflow.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkRepository
{
    public class SongEntityFrameworkRepository : ISongRepository
    {
        private readonly AppDataContext _context;
        private readonly ISongDataMapper _songDataMapper;

        public SongEntityFrameworkRepository(AppDataContext context, ISongDataMapper songDataMapper)
        {
            _context = context;
            _songDataMapper = songDataMapper;
        }

        public void CreateSong(ISongDomainModel songDomainModel, Guid albumId, Guid artistId)
        {
            var songEntityModel = _songDataMapper.ToEntityModel(songDomainModel);
            var song = new SongEntityModel
            {
                Name = songEntityModel.Name,
                LinkYT = songEntityModel.LinkYT,
                LinkSptfy = songEntityModel.LinkSptfy,
                AlbumId = albumId,
                ArtistId = artistId
            };
            _context.Song.Add(song);
            _context.SaveChanges();
        }

        public void UpdateSong(ISongDomainModel songDomainModel)
        {
            var songEntityModel = _songDataMapper.ToEntityModel(songDomainModel);

            var existingSongEntityModel = _context.Song.Single(a => a.SongId == songEntityModel.SongId);
            var existingArtistEntityModel = _context.Artist.Single(a => a.ArtistId == songEntityModel.ArtistId);
            var existingAlbumEntityModel = _context.Album.Single(a => a.AlbumId == songEntityModel.AlbumId);

            existingSongEntityModel.Name = songEntityModel.Name;
            existingSongEntityModel.LinkYT = songEntityModel.LinkYT;
            existingSongEntityModel.LinkSptfy = songEntityModel.LinkSptfy;
            existingSongEntityModel.Album = existingAlbumEntityModel;
            existingSongEntityModel.Artist = existingArtistEntityModel;

            _context.Update(existingSongEntityModel);
            _context.SaveChanges();
        }

        public void DeleteSongById(Guid songId)
        {
            var existingSongEntityModel = _context.Song.Single(s => s.SongId == songId);

            _context.Song.Remove(existingSongEntityModel);
            _context.SaveChanges();
        }

        public ISongDomainModel GetSongById(Guid songId)
        {
            return _songDataMapper.ToDomainModel(_context.Song.Single(b => b.SongId == songId));
        }

        public ISongDomainModel GetSongByName(string songName)
        {
            return _songDataMapper.ToDomainModel(_context.Song.Single(b => b.Name.Contains(songName)));
        }

        public List<ISongDomainModel> GetAllSongs()
        {
            List<ISongDomainModel> listDomainModel = new List<ISongDomainModel>();
            List<SongEntityModel> allElementsEntityModel;
            allElementsEntityModel=  _context.Song.ToList();

            foreach (var item in allElementsEntityModel)
            {
                listDomainModel.Add(_songDataMapper.ToDomainModel(item));
            }

            return listDomainModel;
        }
    }
}
