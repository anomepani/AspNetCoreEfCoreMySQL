using System;
using System.Collections.Generic;

namespace AspNetMySQL.Models
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
