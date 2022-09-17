using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Market
    {
        public int Id { get; set; }
    }

    public class MarketsData
    {
        public List<Market> Markets { get; set; }
    }
}
