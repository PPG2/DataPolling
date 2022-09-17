using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Sport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Translation { get; set; }
    }

    public class SportsData
    {
        public List<Sport> Sports { get; set; }
    }
}
