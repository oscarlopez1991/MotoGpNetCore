using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MotoGp.Api.Application.Tests.MockRepository;
using MotoGp.AspNetCore.WebApi.Application.Tests.Mocks;
using MotoGpWebApi.Models;
using MotoGpWebApi.Service;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGp.Api.Application.Tests
{
    [TestClass]
    public class MotoGpServiceTest
    {
        private static IMotoGpService _motoGpService;
        private static IMotoGpService _motoGpServiceDbContextAsync;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            Mock<MotoGPContext> _motoGpContext = new MotoGpContextMock()._mockMotoGpContext;
            _motoGpService = new MotoGpService(_motoGpContext.Object);

            Mock<MotoGPContext> _motoGpContextAsync = new MotoGpContextAsyncMock()._mockMotoGpContextAsync;
            _motoGpServiceDbContextAsync = new MotoGpService(_motoGpContextAsync.Object);
        }

        [TestMethod]
        public void GetEvents_ReturnsThreeEventDTO()
        {
            var events = _motoGpService.GetEvents();

            Assert.AreEqual(events.GetType(), typeof(List<EventDTO>));
            Assert.IsNotNull(events);
            Assert.AreEqual(3, events.Count);
            Assert.AreEqual(1, events[0].Id);
            Assert.AreEqual("CircuitTest1", events[0].NameCircuit);
            Assert.AreEqual("EventTest1", events[0].NameEvent);
        }

        [TestMethod]
        public async Task GetEventDetailAsync_ByFirstElement_ReturnsEventDetailDTO()
        {
            const int FIRST_ELEMENT = 1;

            var eventDetail = await _motoGpServiceDbContextAsync.GetEventDetailAsync(FIRST_ELEMENT);

            Assert.AreEqual(eventDetail.GetType(), typeof(EventDetailDTO));
            Assert.IsNotNull(eventDetail);
            Assert.AreEqual(1, eventDetail.Id);
            Assert.AreEqual("CircuitTest1", eventDetail.NameCircuit);
            Assert.AreEqual("EventTest1", eventDetail.NameEvent);
        }

        [TestMethod]
        public async Task GetEventDetailAsync_NotExistsElement_ReturnsNull()
        {
            const int NOT_EXISTS_ELEMENT = 4;

            var eventDetail = await _motoGpServiceDbContextAsync.GetEventDetailAsync(NOT_EXISTS_ELEMENT);

            Assert.IsNull(eventDetail);      
        }
    }
}
