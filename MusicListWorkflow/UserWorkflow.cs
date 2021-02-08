using MusicListWorkflow.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.Contracts;

namespace MusicListWorkflow
{
    public class UserWorkflow : IUserWorkflow
    {
        private readonly IUserLogicMapper _userLogicMapper;
        private readonly IUserRepository _userRepository;

        public UserWorkflow(IUserLogicMapper userLogicMapper, IUserRepository userRepository)
        {
            _userLogicMapper = userLogicMapper;
            _userRepository = userRepository;
        }
        public void CreateUser(IUserViewModel userDomainModel)
        {
            var domainModel = _userLogicMapper.ToDomainModel(userDomainModel);
            _userRepository.CreateUser(domainModel);
        }

        public IUserViewModel GetUserByName(string userName)
        {
            try
            {
                var domainModel = _userRepository.GetUserByName(userName);
                return _userLogicMapper.ToViewModel(domainModel);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
