using CroweHorwathAssess.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CroweHorwathAssess.Controllers
{
    [RoutePrefix("message")]
    public class MessageController : ApiController
    {
        [HttpGet]
        [Route("Greeting")]
        public IHttpActionResult GetGreeting(int sourceTypeID)
        {
            return Ok(MessageService.GetMessage(sourceTypeID));
        }
    }
}