using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Bett
    {
        public User user { get; set; }

        public Event match { get; set; }

        public Sport Sport { get; set; }


    }
}
