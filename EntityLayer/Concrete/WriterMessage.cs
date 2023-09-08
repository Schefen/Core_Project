using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WriterMessage
    {
        [Key]
        public int WriterMessageId { get; set; }
        public string WriterMessageSender { get; set; }
        public string WriterMessageReceiver { get; set; }
        public string WriterMessageSubject { get; set; }
        public string WriterMessageContent { get; set; }
        public DateTime WriterMessageDate { get; set; }
    }
} 
