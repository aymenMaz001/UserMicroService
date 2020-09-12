using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application.Repositories;
using Moq;
using Microsoft.AspNetCore.Mvc;

namespace UserMicroService.UseCases.GetAllUsers.Tests
{
    [TestClass()]
    public class GetAllUsersControllerTests
    {
        private Mock<IUserReadOnlyRepository> userRepository;

        [TestInitialize]
        public void SetUp()
        {
            // Arrange
            userRepository = new Mock<IUserReadOnlyRepository>();
        }


        [TestMethod()]
        public async System.Threading.Tasks.Task GetTest()
        {
            // Act
            var controller = new GetAllUsersController(userRepository.Object);
            var actionResult = controller.Get();
            var okResult = await actionResult as OkObjectResult;

            Assert.AreEqual(okResult.StatusCode, (int)System.Net.HttpStatusCode.OK);
        }
    }
}