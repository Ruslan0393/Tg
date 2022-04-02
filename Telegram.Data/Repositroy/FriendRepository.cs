using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Data.Contexts;
using Telegram.Data.IRepository;
using Telegram.Domain.Models;

namespace Telegram.Data.Repositroy
{
    public class FriendRepository : GenericRepository<Friend>, IFriendRepository
    {
        public FriendRepository(TelegramDbContext telegramDbContext) : base(telegramDbContext)
        {
        }
    }
}
