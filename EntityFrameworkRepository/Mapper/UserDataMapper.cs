using DomainModels;
using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using EntityFrameworkRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRepository.Mapper
{
    public class UserDataMapper : IUserDataMapper
    {

        public IUserDomainModel ToDomainModel(UserEntityModel entityModel)
        {
            var domainModel = new UserDomainModel();
            domainModel.Password = entityModel.Password;
            domainModel.SecurityAnswer = entityModel.SecurityAnswer;
            domainModel.UserId = entityModel.UserId;
            domainModel.UserName = entityModel.UserName;
            return domainModel;
        }

        public UserEntityModel ToEntityModel(IUserDomainModel domainModel)
        {
            var entityModel = new UserEntityModel();
            entityModel.Password = domainModel.Password;
            entityModel.SecurityAnswer = domainModel.SecurityAnswer;
            entityModel.UserId = domainModel.UserId;
            entityModel.UserName = domainModel.UserName;
            return entityModel;
        }
    }
}
