using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace Assignment1_N01614330.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Receives an integer and return the value which is 10 more than that.
        /// </summary>
        /// <param name="id">The integer input</param>
        /// <returns>Integer output after adding 10</returns>
        /// <example>
        /// GET localhost/api/AddTen/21 -> 31
        /// GET localhost/api/AddTen/0 -> 10
        /// GET localhost/api/AddTen/-9 -> 1
        /// </example>
        
        [HttpGet]
        [Route("api/AddTen/{id}")]
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
