using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Telegram.Data.IRepository;
using Telegram.Domain.Models;
using Telegram.Service.Interfaces;
using Telegram.ViewModel.User;

namespace Telegram.Service.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }



        public async Task<User> CreateAsync(CreateUserViewModel model)
        {
            User user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                Password = model.Password,
                Image = model.Image
            };

            return await _userRepository.CreateAsynce(user);
        }

        public async Task<bool> DeleteAsync(Expression<Func<User, bool>> expression)
        {
            return await _userRepository.DeleteAsync(expression);
        }

        public async Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>> expression = null)
        {
            return await _userRepository.GetAllAsync(expression);
        }

        public async Task<User> GetAsync(Expression<Func<User, bool>> expression)
        {
            return await _userRepository.GetAsync(expression);
        }

        public async Task<User> UpdateAsync(User user)
        {
            return await _userRepository.UpdateAsync(user);
        }


    }
}
