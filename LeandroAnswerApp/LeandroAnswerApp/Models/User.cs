using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;
using System.Net;

namespace AnswerApp.Models
{
    public class User
    {
        public RestRequest request { get; set; }

        const string mimetype = "application/json";
        const string contentype = "Content-Type";

        public User()
        {
            request = new RestRequest();

            Answers = new HashSet<Answer>();
            Asks = new HashSet<Ask>();
            ChatReceivers = new HashSet<Chat>();
            ChatSenders = new HashSet<Chat>();
            Likes = new HashSet<Like>();

            UserRole = new UserRole();
        }


        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserPassword { get; set; }
        public int StrikeCount { get; set; }
        public string BackUpEmail { get; set; }
        public string JobDescription { get; set; }
        public int UserStatusId { get; set; }
        public int CountryId { get; set; }
        public int UserRoleId { get; set; }

        public virtual Country Country { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual UserStatus UserStatus { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Ask> Asks { get; set; }
        public virtual ICollection<Chat> ChatReceivers { get; set; }
        public virtual ICollection<Chat> ChatSenders { get; set; }
        public virtual ICollection<Like> Likes { get; set; }

    
    }
}
