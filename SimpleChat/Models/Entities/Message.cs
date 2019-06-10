using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleChat.Models.Entities
{
    public class Message
    {
        public int Id { get; set; }

        public int? UserFromId { get; set; }
        public User UserFrom { get; set; }

        public int? UserToId { get; set; }
        public User UserTo { get; set; }

        public int? ContentId { get; set; }
        public Content Content { get; set; }

    }
}
