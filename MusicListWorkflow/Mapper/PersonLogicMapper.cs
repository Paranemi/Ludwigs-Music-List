using DomainModels;
using DomainModels.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using ViewModels;
using ViewModels.Contracts;

namespace MusicListWorkflow.Mapper
{
    public class PersonLogicMapper : IPersonLogicMapper
    {
        private readonly IArtistLogicMapper _artistLogicMapper;

        public PersonLogicMapper(IArtistLogicMapper artistLogicMapper)
        {
            _artistLogicMapper = artistLogicMapper;
        }

        public IPersonDomainModel ToDomainModel(IPersonViewModel viewModel)
        {
            var domainModel = new PersonDomainModel();
            domainModel.PersonId = viewModel.PersonId;
            domainModel.FirstName = viewModel.FirstName;
            domainModel.LastName = viewModel.LastName;
            domainModel.From = viewModel.From;
            domainModel.To = viewModel.To;
            domainModel.Born = viewModel.Born;
            domainModel.Died = viewModel.Died;
            domainModel.ImageUrl = viewModel.ImageUrl;
            domainModel.ArtistId = viewModel.ArtistId;
            domainModel.Artist = _artistLogicMapper.ToDomainModel(viewModel.Artist);
            return domainModel;
        }
        public IPersonViewModel ToViewModel(IPersonDomainModel domainModel)
        {
            var viewModel = new PersonViewModel();
            viewModel.PersonId = domainModel.PersonId;
            viewModel.FirstName = domainModel.FirstName;
            viewModel.LastName = domainModel.LastName;
            viewModel.From = domainModel.From;
            viewModel.To = domainModel.To;
            viewModel.Born = domainModel.Born;
            viewModel.Died = domainModel.Died;
            viewModel.ImageUrl = domainModel.ImageUrl;
            viewModel.ArtistId = domainModel.ArtistId;
            viewModel.Artist = _artistLogicMapper.ToViewModel(domainModel.Artist);
            return viewModel;
        }
    }
}
