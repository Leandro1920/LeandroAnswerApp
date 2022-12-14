using System;
using System.Collections.Generic;
using System.Text;

namespace AnswerApp.Models
{
    public  class UserStatus
    {
        public UserStatus()
        {
            Users = new HashSet<User>();
        }

        public int UserStatusId { get; set; }
        public string Status { get; set; }

        public virtual ICollection<User> Users { get; set; }

    }
}
