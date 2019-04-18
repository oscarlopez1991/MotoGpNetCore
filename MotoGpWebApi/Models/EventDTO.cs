using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGpWebApi.Models
{
    public class EventDTO
    {
        public byte Id { get; set; }
        public string NameEvent { get; set; }
        public DateTime Date { get; set; }
        public string NameCircuit { get; set; }
        public string Country { get; set; }
    }
}
