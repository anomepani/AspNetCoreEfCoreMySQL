using System;
using System.Collections.Generic;

namespace AspNetMySQL.Models
{
    public partial class UserAnswer
    {
        public int Id { get; set; }
        public string Qid { get; set; }
        public string Ans { get; set; }
        public string Correctans { get; set; }
        public string Eid { get; set; }
        public string Username { get; set; }
    }
}
