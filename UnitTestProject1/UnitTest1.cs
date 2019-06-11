using eShopModernizedMVC;
using Microsoft.Owin.Testing;
using NUnit.Framework;
using Owin;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private TestServer _server;

        [SetUp]
        public void Setup()
        {
            _server = TestServer.Create<Startup>();
        }

        [TearDown]
        public void FixtureDispose()
        {
            _server.Dispose();
        }

        [Test]
        public void Test1()
        {
            var response = _server.HttpClient.GetAsync("/Catalog/Details/1").Result;
            Assert.Pass();
        }
    }
}