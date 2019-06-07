using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CachingMgt.Models
{
    public class UserInfo
    {
        public Guid GuidId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}