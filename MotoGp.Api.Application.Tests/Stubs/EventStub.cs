using MotoGpWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MotoGp.Api.Application.Tests.Stubs
{
    public static class EventStub
    {
        private static readonly Circuit circuit_1 = new Circuit()
        {
            Id = 1,
            Name = "CircuitTest1",
            Country = "CountryTest1",
            Length = 1000,
            NumberOfCurves = 12,
            Width = 13,
            StraightLonger = 2000,
            RaceLapRecord = new TimeSpan(0, 1, 0)
        };

        private static readonly Circuit circuit_2 = new Circuit()
        {
            Id = 2,
            Name = "CircuitTest2",
            Country = "CountryTest2",
            Length = 3000,
            NumberOfCurves = 14,
            Width = 12,
            StraightLonger = 8989,
            RaceLapRecord = new TimeSpan(0, 2, 1)
        };

        private static readonly Circuit circuit_3 = new Circuit()
        {
            Id = 3,
            Name = "CircuitTest3",
            Country = "CountryTest3",
            Length = 4000,
            NumberOfCurves = 18,
            Width = 13,
            StraightLonger = 5000,
            RaceLapRecord = new TimeSpan(0, 2, 0)
        };

        public static readonly IQueryable<Event> events = new List<Event>()
        {
            new Event { Id = 1, Name = "EventTest1",
                    Date = new DateTime(2019, 3, 19),
                    Circuit = circuit_1
            },

            new Event { Id = 2, Name = "EventTest2",
                    Date = new DateTime(2019, 4, 1),
                    Circuit = circuit_2
            },

            new Event { Id = 3, Name = "EventTest3",
                    Date = new DateTime(2019, 4, 8),
                    Circuit = circuit_3
            }

        }.AsQueryable();
    }
}
