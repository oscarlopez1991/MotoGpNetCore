using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotoGpWebApi.Models;

namespace MotoGpWebApi.Service
{
    public class MotoGpService : IMotoGpService
    {
        private readonly MotoGPContext _db;

        public MotoGpService(MotoGPContext db)
        {
            _db = db;
        }
        
        public IList<EventDTO> GetEvents()
        {
            var events = _db.Event.Include(e => e.Circuit).Select(e =>
                new EventDTO()
                {
                    Id = e.Id,
                    NameEvent = e.Name,
                    Date = e.Date,
                    NameCircuit = e.Circuit.Name,
                    Country = e.Circuit.Country
                }).ToList();

            return events;
        }

        public async Task<EventDetailDTO> GetEventDetailAsync(int id)
        {
            var eventDetail = await _db.Event.Include(e => e.Circuit).Select(e =>
            new EventDetailDTO()
            {
                Id = e.Id,
                NameEvent = e.Name,
                Date = e.Date,
                NameCircuit = e.Circuit.Name,
                Country = e.Circuit.Country,
                Length = e.Circuit.Length,
                NumberOfCurves = e.Circuit.NumberOfCurves,
                Width = e.Circuit.Width,
                StraightLonger = e.Circuit.StraightLonger,
                RaceLapRecord = e.Circuit.RaceLapRecord
            }).SingleOrDefaultAsync(e => e.Id == id);

            return eventDetail;
        }
    }
}
