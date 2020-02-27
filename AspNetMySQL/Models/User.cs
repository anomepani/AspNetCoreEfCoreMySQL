using System;
using System.Collections.Generic;

namespace AspNetMySQL.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rollno { get; set; }
        public string Branch { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }
        public long Phno { get; set; }
        public string Password { get; set; }
    }
}
