using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01614330.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Returns the string "Hello world".
        /// </summary>
        /// <returns>"Hello World!"</returns>
        /// <example>
        /// POST localhost/api/Greeting -> "Hello World!"
        /// </example>
        [HttpPost]
        [Route("api/Greeting")]
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Returns the string "Greetings to {id} people!" where {id} is an integer value.
        /// </summary>
        /// <param name="id">The number of people to greet</param>
        /// <returns>"Greetings to {id} people!"</returns>
        /// <example>
        /// POST localhost/api/Greeting -> "Hello World!"
        /// </example>
        /// GET localhost/api/Greeting/3 -> "Greetings to 3 people!"
        /// GET localhost/api/Greeting/6 -> "Greetings to 6 people!"
        /// GET localhost/api/Greeting/0 -> "Greetings to 0 people!"

        [HttpGet]
        [Route("api/Greeting/{id}")]
        public string Get(int id)
        {
            return $"Greetings to {id} people!";
        }



    }
}
