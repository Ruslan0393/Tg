 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Domain.Common
{
    public class BaseItems
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime DeleteDate { get; set; }
    }
}
