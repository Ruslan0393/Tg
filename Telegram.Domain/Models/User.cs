using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Domain.Common;

namespace Telegram.Domain.Models
{
    public class User : BaseItems
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
 
     
    }
}
