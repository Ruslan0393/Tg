using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Domain.Common;

namespace Telegram.Domain.Models
{
    public class Friend : BaseItems
    {
        public long FriendId { get; set; }

        public long UserId { get; set; }

    }
}
