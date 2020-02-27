using System;
using System.Collections.Generic;

namespace AspNetMySQL.Models
{
    public partial class History
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Eid { get; set; }
        public int Score { get; set; }
        public int Level { get; set; }
        public int Correct { get; set; }
        public int Wrong { get; set; }
        public DateTime Date { get; set; }
        public long Timestamp { get; set; }
        public string Status { get; set; }
        public string ScoreUpdated { get; set; }
    }
}
