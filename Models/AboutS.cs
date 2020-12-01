using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSRS.Models
{
    public class AboutS
    {
        public int Id { get; set; }
        public String first { get; set; }
        public String second { get; set; }
        public String third { get; set; }

        public static implicit operator AboutS(Account v)
        {
            throw new NotImplementedException();
        }
    }
}
