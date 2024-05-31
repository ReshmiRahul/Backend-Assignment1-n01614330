using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01614330.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Receives an integer and returns the square of the integer input
        /// </summary>
        /// <param name="id">Integer input</param>
        /// <returns>input squared</returns>
        /// <example>
        /// GET localhost/api/Square/2 -> 4
        /// GET localhost/api/Square/-2 -> 4
        /// GET localhost/api/Square/10 -> 100
        /// </example>
       
        [HttpGet]
        [Route("api/Square/{id}")]
        public int Get(int id)
        {
            return id * id;
        }
    }
}
