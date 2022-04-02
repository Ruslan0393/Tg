using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Telegram.Domain.Models;

namespace Telegram.Data.IRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
       
    }
}
