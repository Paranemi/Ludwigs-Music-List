using MusicListWorkflow.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.Contracts;

namespace MusicListWorkflow
{
    public class ArtistWorkflow : IArtistWorkflow
    {
        private readonly IArtistLogicMapper _artistLogicMapper;
        private readonly IArtistRepository _artistRepository;

        public ArtistWorkflow(IArtistLogicMapper artistLogicMapper, IArtistRepository artistRepository)
        {
            _artistLogicMapper = artistLogicMapper;
            _artistRepository = artistRepository;
        }

        public void CreateArtist(IArtistViewModel artistViewModel)
        {
            var domainModel = _artistLogicMapper.ToDomainModel(artistViewModel);
            _artistRepository.CreateArtist(domainModel);
        }

        public void DeleteArtistById(Guid artistId)
        {
            _artistRepository.DeleteArtistById(artistId);
        }

        public IArtistViewModel GetArtistById(Guid artistId)
        {
            var domainModel = _artistRepository.GetArtistById(artistId);
            return _artistLogicMapper.ToViewModel(domainModel);
        }

        public IArtistViewModel GetArtistByName(string artistName)
        {
            var domainModel = _artistRepository.GetArtistByName(artistName);
            return _artistLogicMapper.ToViewModel(domainModel);
        }

        public Guid GetArtistIdByName(string artistName)
        {
            return _artistRepository.GetArtistIdByName(artistName);
        }

        public void UpdateArtist(IArtistViewModel artistViewModel)
        {
            var artistDomainModel = _artistLogicMapper.ToDomainModel(artistViewModel);
            _artistRepository.UpdateArtist(artistDomainModel);
        }
    }
}
