using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MotoGp.Api.Application.Tests.MockRepository;
using MotoGp.AspNetCore.WebApi.Application.Tests.Mocks;
using MotoGpWebApi.Controllers;
using MotoGpWebApi.Models;
using MotoGpWebApi.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoGp.AspNetCore.WebApi.Application.Tests.Tests
{
    public class MotoGpControllerTest
    {
        private static MotoGpController _motoGpController;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            Mock<IMotoGpService> _motoGpService = new MotoGpServiceMock()._mockMotoGpService;
            _motoGpController = new MotoGpController(_motoGpService.Object);
        }

        [TestMethod]
        public void GetEvents_ReturnsThreeEventDTO()
        {
            var events = _motoGpController.GetEvents();

            Assert.AreEqual(events.GetType(), typeof(List<EventDTO>));
            Assert.IsNotNull(events);
            Assert.AreEqual(3, events.Count);
            Assert.AreEqual(1, events[0].Id);
            Assert.AreEqual("CircuitTest1", events[0].NameCircuit);
            Assert.AreEqual("EventTest1", events[0].NameEvent);
        }

    }
}
