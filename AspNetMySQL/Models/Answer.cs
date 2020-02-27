using System;
using System.Collections.Generic;

namespace AspNetMySQL.Models
{
    public partial class Answer
    {
        public int Id { get; set; }
        public string Qid { get; set; }
        public string Ansid { get; set; }
    }
}
