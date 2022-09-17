using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Event
    {
        public int Id { get; set; }
    }

    public class EventsData
    {
        public List<Event> Events { get; set; }
    }
}
