using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AyseSagcolak.Models
{
    public class Subscriber
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}