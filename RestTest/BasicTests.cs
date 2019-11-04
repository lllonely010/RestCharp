using System.Net;
using RestSharp;
using NUnit.Framework;

namespace RestTest
{
    [TestFixture]
    public class BasicTests
    {
        [Test]
        public void StatusCodeTest()
        {
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("nl/3825", Method.GET);

            IRestResponse response = client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void ContentTypeTest()
        {
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("nl/3825", Method.GET);

            IRestResponse response = client.Execute(request);

            Assert.That(response.ContentType, Is.EqualTo("application/json"));
        }
      
    }
}
