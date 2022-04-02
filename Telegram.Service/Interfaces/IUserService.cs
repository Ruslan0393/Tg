using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Telegram.Domain.Common;
using Telegram.Domain.Models;
using Telegram.ViewModel.User;

namespace Telegram.Service.Interfaces
{
    public interface IUserService
    {
        Task<User> GetAsync(Expression<Func<User, bool>> expression);
        Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>> expression = null);
        Task<User> CreateAsync(CreateUserViewModel user);
        Task<bool> DeleteAsync(Expression<Func<User, bool>> expression);
        Task<User> UpdateAsync(User user);
      
    }
}
