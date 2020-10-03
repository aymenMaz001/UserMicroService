using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application.Repositories;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Domain;
using System;

namespace UserMicroService.UseCases.Authentification.Tests
{
    [TestClass()]
    public class AuthentificationControllerTests
    {
        private Mock<IUserReadOnlyRepository> userRepository;
        private AuthParameters authParameters;

        [TestInitialize]
        public void SetUp()
        {
            // Arrange
            userRepository = new Mock<IUserReadOnlyRepository>();
        }


        [TestMethod()]
        public async System.Threading.Tasks.Task PostTestAsync_ValidUser_ReturnOK()
        {
            var user = new User(1, "agent", "agent", Domain.Enum.Role.AGENT,new DateTime(2020,01,01), null);
            authParameters = new AuthParameters("agent", "agent");
            // Act
            userRepository.Setup(u => u.Authentification("agent", "agent")).ReturnsAsync(user);
            var controller = new AuthentificationController(userRepository.Object);
            var actionResult = controller.Post(authParameters);
            var okResult = await actionResult as OkObjectResult;

            Assert.AreEqual(okResult.StatusCode, (int)System.Net.HttpStatusCode.OK);
        }
    }
}