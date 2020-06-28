﻿using StartupProject.Web;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace StartupProject.FunctionalTests
{
    public class RootIndexPage : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public RootIndexPage(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ReturnsWithCorrectMessage()
        {
            HttpResponseMessage response = await _client.GetAsync("/");
            response.EnsureSuccessStatusCode();
            string stringResponse = await response.Content.ReadAsStringAsync();

            Assert.Contains("StartupProject", stringResponse);
        }
    }
}
