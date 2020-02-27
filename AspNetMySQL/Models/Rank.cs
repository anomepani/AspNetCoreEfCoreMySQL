using System;
using System.Collections.Generic;

namespace AspNetMySQL.Models
{
    public partial class Rank
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Score { get; set; }
        public DateTime Time { get; set; }
    }
}
