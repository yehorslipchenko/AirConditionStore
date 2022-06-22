using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AirConditionStore.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;

namespace AirCondition.IntegrationTest.API
{
    public class UserApiTest
    {
        private readonly HttpClient client;

        public UserApiTest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Theory]
        [InlineData("GET")]
        public async Task UserGetAllTestAsync(string method)
        {
            // Arrange
            var request = new HttpRequestMessage(new HttpMethod(method), "/api/user/");
            
            // Act
            var response = await client.SendAsync(request);
            
            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    } 
}