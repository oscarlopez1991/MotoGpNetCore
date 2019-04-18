using Microsoft.AspNetCore.Mvc;
using MotoGpWebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MotoGpWebApi.Service
{    
    public interface IMotoGpService
    {
        IList<EventDTO> GetEvents();

        Task<EventDetailDTO> GetEventDetailAsync(int id);
    }
}
