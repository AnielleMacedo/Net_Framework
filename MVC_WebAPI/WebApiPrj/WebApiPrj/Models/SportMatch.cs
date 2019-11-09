using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiPrj.Models
{
    public class SportMatch
    {
        public int Id { get; set; }
        public string AwayTeam { get; set; }
        public string HomeTeam { get; set; }
        public int AwayScore { get; set; }
        public int HomeScore { get; set; }
        public DateTime Day { get; set; }

    }
}