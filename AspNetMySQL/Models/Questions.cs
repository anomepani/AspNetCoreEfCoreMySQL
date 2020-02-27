using System;
using System.Collections.Generic;

namespace AspNetMySQL.Models
{
    public partial class Questions
    {
        public int Id { get; set; }
        public string Eid { get; set; }
        public string Qid { get; set; }
        public string Qns { get; set; }
        public int Choice { get; set; }
        public int Sn { get; set; }
    }
}
