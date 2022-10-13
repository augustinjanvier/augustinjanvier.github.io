using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPokedex
{
    public class Pokemon
    {
        public int id { get; set; }
        public Name name { get; set; }
        public string[] type { get; set; }
        public Base _base { get; set; }
        public string species { get; set; }
        public string description { get; set; }
        public Evolution evolution { get; set; }
        public Profile profile { get; set; }
        public Image image { get; set; }
    }

    public class Name
    {
        public string english { get; set; }
        public string japanese { get; set; }
        public string chinese { get; set; }
        public string french { get; set; }
    }

    public class Base
    {
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpAttack { get; set; }
        public int SpDefense { get; set; }
        public int Speed { get; set; }
    }

    public class Evolution
    {
        public string[][] next { get; set; }
        public string[] prev { get; set; }
    }

    public class Profile
    {
        public string height { get; set; }
        public string weight { get; set; }
        public string[] egg { get; set; }
        public string[][] ability { get; set; }
        public string gender { get; set; }
    }

    public class Image
    {
        public string sprite { get; set; }
        public string thumbnail { get; set; }
        public string hires { get; set; }
    }

}