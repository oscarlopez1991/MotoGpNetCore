using System;
using System.Collections.Generic;

namespace MotoGpWebApi.Models
{
    public partial class Event
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public byte CircuitId { get; set; }
        public virtual Circuit Circuit { get; set; }
    }
}
