using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Domain.Models;

namespace Telegram.Data.Contexts
{
    public class TelegramDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Friend> Friends { get; set; }

        public virtual DbSet<Message> Messages { get; set; }

        public TelegramDbContext(DbContextOptions<TelegramDbContext> options) : base(options)
        {
        }


    }
}
