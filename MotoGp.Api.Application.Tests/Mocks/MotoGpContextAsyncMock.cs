using Moq;
using MotoGp.Api.Application.Tests.Stubs;
using MotoGpWebApi.Models;

namespace MotoGp.AspNetCore.WebApi.Application.Tests.Mocks
{
    public class MotoGpContextAsyncMock
    {
        public Mock<MotoGPContext> _mockMotoGpContextAsync;

        public MotoGpContextAsyncMock()
        {
            var events = EventStub.events.ToAsyncDbSetMock();

            _mockMotoGpContextAsync = new Mock<MotoGPContext>();
            _mockMotoGpContextAsync.Setup(x => x.Event).Returns(events.Object);
        }
    }
}
