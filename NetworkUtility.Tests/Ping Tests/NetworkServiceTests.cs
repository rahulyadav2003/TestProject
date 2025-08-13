using FluentAssertions;
using NetworkUtility.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NetworkUtility.Tests.Ping_Tests
{
    public class NetworkServiceTests 
    {
        [Fact]
        public void NetworkService_PingTest_ReturnString()
        {
            //Arrange
            var pingService = new NetworkService();

            //Act
            var result = pingService.PingTest();

            //Assert

            result.Should().Be("Successfully: Ping Sent!");
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Contain("Successfully", Exactly.Once());
            result.Should().Contain("Ping Sent", Exactly.Once());   
            result.Should().NotBeNullOrEmpty();

        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData (2, 3, 5)]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            //Arrange
            var pingResult = new NetworkService();

            //act
            var result = pingResult.PingTimeout(a, b);

            //Assert

            result.Should().Be(expected);
            result.Should().BeGreaterThan(-100);
            result.Should().BeLessThan(100);
            result.Should().BeInRange(-100, 100);
        }
    }
}
