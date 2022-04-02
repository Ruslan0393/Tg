using Telegram.Domain.Common;

namespace Telegram.Domain.Models
{
    public class Message : BaseItems
    {
        public string Text { get; set; }

        public long ClientId { get; set; }

        public long UserId { get; set; }

        public bool Owner { get; set; }

    }
}
