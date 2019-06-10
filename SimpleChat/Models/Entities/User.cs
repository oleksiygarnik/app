using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleChat.Models.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        [JsonIgnore]
        public IEnumerable<UserGroup> UserGroups { get; set; }

        public User()
        {
            UserGroups = new List<UserGroup>();
        }
    }
}
