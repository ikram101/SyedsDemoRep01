using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapleMvc01.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserFullName { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string PostName { get; set; }

        public User User { get; set; } 
    }
}