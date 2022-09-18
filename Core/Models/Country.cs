using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Translation { get; set; }
    }

    public class CountriesData
    {
        public List<Country> Countries { get; set; }
    }
}
