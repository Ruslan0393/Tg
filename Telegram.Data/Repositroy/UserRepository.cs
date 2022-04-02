using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Telegram.Data.Contexts;
using Telegram.Data.IRepository;
using Telegram.Domain.Models;

namespace Telegram.Data.Repositroy
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
#pragma warning disable
        private TelegramDbContext _telegramDbContext;
        public UserRepository(TelegramDbContext telegramDbContext) : base(telegramDbContext)
        {
            _telegramDbContext = telegramDbContext;
        }

    

    
    }
}
