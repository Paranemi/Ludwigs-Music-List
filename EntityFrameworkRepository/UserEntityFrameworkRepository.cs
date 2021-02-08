using DomainModels.Contracts;
using EntityFrameworkRepository.EFModels;
using EntityFrameworkRepository.Interfaces;
using EntityFrameworkRepository.Mapper;
using Repository.Contracts;
using System.Linq;

namespace EntityFrameworkRepository
{
    public class UserEntityFrameworkRepository : IUserRepository
    {
        private readonly AppDataContext _context;
        private readonly IUserDataMapper _userDataMapper;

        public UserEntityFrameworkRepository(AppDataContext context, IUserDataMapper userDataMapper)
        {
            _context = context;
            _userDataMapper = userDataMapper;
        }

        public void CreateUser(IUserDomainModel userDomainModel)
        {
            var userEntityModel = _userDataMapper.ToEntityModel(userDomainModel);
            var user = new UserEntityModel
            {
                UserName = userEntityModel.UserName,
                Password = userEntityModel.Password,
                SecurityAnswer = userEntityModel.SecurityAnswer
            };
            _context.User.Add(user);

            _context.SaveChanges();
        }
        
        public IUserDomainModel GetUserByName(string userName)
        {
            try
            {
                return _userDataMapper.ToDomainModel(_context.User.Single(b => b.UserName.Contains(userName)));
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}
