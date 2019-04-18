using Microsoft.EntityFrameworkCore;
using Moq;
using MotoGp.Api.Application.Tests.Stubs;
using MotoGpWebApi.Models;
using System.Linq;

namespace MotoGp.Api.Application.Tests.MockRepository
{
    public class MotoGpContextMock
    {
        public Mock<MotoGPContext> _mockMotoGpContext;

        public MotoGpContextMock()
        {
            _mockMotoGpContext = new Mock<MotoGPContext>();
            Setup();
        }

        private void Setup()
        {
            Mock<DbSet<Event>> mockSetEvent = new Mock<DbSet<Event>>();

            mockSetEvent.As<IQueryable<Event>>().Setup(m => m.Provider).Returns(EventStub.events.Provider);
            mockSetEvent.As<IQueryable<Event>>().Setup(m => m.Expression).Returns(EventStub.events.Expression);
            mockSetEvent.As<IQueryable<Event>>().Setup(m => m.ElementType).Returns(EventStub.events.ElementType);
            mockSetEvent.As<IQueryable<Event>>().Setup(m => m.GetEnumerator()).Returns(EventStub.events.GetEnumerator());

            _mockMotoGpContext.Setup(c => c.Event).Returns(mockSetEvent.Object);
        }
    }
}
