using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Tournament
    {
        public int Id { get; set; }
    }

    public class TournamentsData
    {
        public List<Tournament> Tournaments { get; set; }
    }
}
