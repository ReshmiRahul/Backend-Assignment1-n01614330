using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01614330.Controllers
{
    public class GreetingsController : ApiController
    {
        public string Get(int id)
        {
            return $"Greetings to {id} people!";
        }
    }
}
