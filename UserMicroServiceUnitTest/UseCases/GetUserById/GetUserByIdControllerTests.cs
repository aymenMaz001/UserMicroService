using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using Application.Repositories;
using Moq;

namespace UserMicroService.UseCases.GetUserById.Tests
{
    [TestClass()]
    public class GetUserByIdControllerTests
    {
        private Mock<IUserReadOnlyRepository> userRepository;

        [TestInitialize]
        public void SetUp()
        {
            // Arrange
            userRepository = new Mock<IUserReadOnlyRepository>();
        }

        [TestMethod()]
        public async System.Threading.Tasks.Task GetUserIdTest()
        {
            // Act
            var controller = new GetUserByIdController(userRepository.Object);
            var actionResult = controller.GetUserId(1);
            var okResult = await actionResult as OkObjectResult;

            Assert.AreEqual(okResult.StatusCode, (int)System.Net.HttpStatusCode.OK);
        }
    }
}