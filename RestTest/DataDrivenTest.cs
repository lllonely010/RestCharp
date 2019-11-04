using System.Net;
using RestSharp;
using NUnit.Framework;

namespace RestTest
{
    [TestFixture]
    public class DataDrivenTest
    {
        [TestCase("nl", "2611", HttpStatusCode.OK, TestName = "Check the status code for NL2611")]
        [TestCase("nl","1234",HttpStatusCode.NotFound,TestName ="Check for status code for NL1000")]
        public void StatusCodeTest(string countryCode, string zipCode, HttpStatusCode expectedCode)
        {
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest($"{countryCode}/{zipCode}", Method.GET);

            IRestResponse response = client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(expectedCode));
        }


      
    }
}
