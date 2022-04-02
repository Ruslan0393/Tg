using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.ViewModel.Message
{
    public class MessageCreateViewModel
    {
        public string Text { get; set; }

        public long ClientId { get; set; }

        public long UserId { get; set; }

        public bool Owner { get; set; }
    }
}
