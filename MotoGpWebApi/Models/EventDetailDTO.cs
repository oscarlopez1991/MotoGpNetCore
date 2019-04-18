using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGpWebApi.Models
{
    public class EventDetailDTO
    {
        public byte Id { get; set; }
        public string NameEvent { get; set; }
        public DateTime Date { get; set; }
        public string NameCircuit { get; set; }
        public string Country { get; set; }
        public short Length { get; set; }
        public byte NumberOfCurves { get; set; }
        public byte Width { get; set; }
        public short StraightLonger { get; set; }
        public TimeSpan RaceLapRecord { get; set; }
    }
}
