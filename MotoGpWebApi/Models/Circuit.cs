using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MotoGpWebApi.Models
{
    public partial class Circuit
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        [RegularExpression (@"^[1-9]\d*$")]
        public short Length { get; set; }
        public byte NumberOfCurves { get; set; }
        public byte Width { get; set; }
        [RegularExpression(@"^[1-9]\d*$")]
        public short StraightLonger { get; set; }
        public TimeSpan RaceLapRecord { get; set; }
        public virtual Event Event { get; set; }
    }
}
