using MotoGpWebApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoGp.AspNetCore.WebApi.Application.Tests.Stubs
{
    public static class EventDTOStub
    {
        public static readonly IList<EventDTO> eventDTOs = new List<EventDTO>()
        {
            new EventDTO { Id = 1, NameEvent = "EventTest1",
                    NameCircuit = "CircuitTest1", 
                    Country = "CountryTest1",
                    Date = new DateTime(2019, 3, 19)
            },

            new EventDTO { Id = 2, NameEvent = "EventTest2",
                    NameCircuit = "CircuitTest2",
                    Country = "CountryTest2",
                    Date = new DateTime(2019, 3, 28)
            },
        };       
    }
}
