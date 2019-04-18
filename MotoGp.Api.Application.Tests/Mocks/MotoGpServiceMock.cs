using Moq;
using MotoGp.Api.Application.Tests.Stubs;
using MotoGp.AspNetCore.WebApi.Application.Tests.Stubs;
using MotoGpWebApi.Service;
using System.Linq;

namespace MotoGp.AspNetCore.WebApi.Application.Tests.Mocks
{    
    public class MotoGpServiceMock
    {
        public Mock<IMotoGpService> _mockMotoGpService;

        public MotoGpServiceMock()
        {
            _mockMotoGpService = new Mock<IMotoGpService>();
            Setup();
        }

        private void Setup()
        {
            _mockMotoGpService.Setup(c => c.GetEvents()).Returns(EventDTOStub.eventDTOs);
        }
    }
}
