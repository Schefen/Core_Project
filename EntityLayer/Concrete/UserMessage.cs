using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserMessage
    {
        [Key]
        public int UserMessageId { get; set; }
        public string UserMessageTitle { get; set; }
        public string UserMessageContent { get; set; }
        public DateTime UserMessageDate { get; set; }
        public bool UserMessageStatus { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
