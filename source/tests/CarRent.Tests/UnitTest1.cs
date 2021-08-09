namespace CarRent.Tests
{
    using System;
    using CarRent.CustomerManagement.Api;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            var c = new CustomerController(null);

            // Act
            var result = c.Get(1);

            // Assert

            Assert.NotNull(result);
        }
    }
}
