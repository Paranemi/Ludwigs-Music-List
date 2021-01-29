using DomainModels;
using DomainModels.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using ViewModels;
using ViewModels.Contracts;

namespace MusicListWorkflow.Mapper
{
    public class UserLogicMapper : IUserLogicMapper
    {

        public IUserDomainModel ToDomainModel(IUserViewModel viewModel)
        {
            var domainModel = new UserDomainModel();
            domainModel.Password = viewModel.Password;
            domainModel.SecurityAnswer = viewModel.SecurityAnswer;
            domainModel.UserId = viewModel.UserId;
            domainModel.UserName = viewModel.UserName;
            return domainModel;
        }

        public IUserViewModel ToViewModel(IUserDomainModel domainModel)
        {
            var viewModel = new UserViewModel();
            viewModel.Password = domainModel.Password;
            viewModel.SecurityAnswer = domainModel.SecurityAnswer;
            viewModel.UserId = domainModel.UserId;
            viewModel.UserName = domainModel.UserName;
            return viewModel;
        }
    }
}
