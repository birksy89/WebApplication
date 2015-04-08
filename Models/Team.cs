using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;




namespace WebApplication.Models
{
   
    public class Rootobject
    {
        public _Links[] _links { get; set; }
        public int count { get; set; }
        public Team[] teams { get; set; }
    }

    public class _Links
    {
        public string self { get; set; }
        public string soccerseason { get; set; }
    }

    public class Team
    {
        public _Links1 _links { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string shortName { get; set; }
        public string squadMarketValue { get; set; }
        public string crestUrl { get; set; }
    }

    public class _Links1
    {
        public Self self { get; set; }
        public Fixtures fixtures { get; set; }
        public Players players { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Fixtures
    {
        public string href { get; set; }
    }

    public class Players
    {
        public string href { get; set; }
    }

}

