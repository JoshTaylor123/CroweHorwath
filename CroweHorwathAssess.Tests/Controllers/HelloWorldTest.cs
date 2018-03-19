using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CroweHorwathAssess.Controllers;
using CroweHorwathAssess.Models;
using System.Web.Http.Results;
using CroweHorwathAssess.DataLayer.Services;

namespace CroweHorwathAssess.Tests.Controllers
{
    /// <summary>
    /// Tests need a local copy of dB.  These are for show unless configured.  Need to abstract away the db connection configuration for them to run.
    /// </summary>
    [TestClass]
    public class HelloWorldTest
    {
        //Test API
        [TestMethod]
        public void TestApi()
        {
            MessageController api = new MessageController();
            var result = api.GetGreeting(1) as OkNegotiatedContentResult<MessageModel>;
            Assert.IsNotNull(result.Content.Text);
        }
        //Test Data Service prior to API
        [TestMethod]
        public void TestDataService()
        {
            var result = MessageService.GetMessage(1);
            Assert.IsNotNull(result.Text);
        }
    }
}
