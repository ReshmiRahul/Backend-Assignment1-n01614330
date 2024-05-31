using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01614330.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Applies 4 mathematical operations to the input {id}.
        /// </summary>
        /// <param name="id">The integer input</param>
        /// <returns>The string shows the results of 4 mathematical operations</returns>
        /// <example>
        /// GET localhost/api/NumberMachine/10 -> "Addition: 20, Multiplication: 20, Subtraction: 5, Division: 5"
        /// GET localhost/api/NumberMachine/-5 -> "Addition: 5, Multiplication: -10, Subtraction: -10, Division: -2.5"
        /// GET localhost/api/NumberMachine/30 -> "Addition: 40, Multiplication: 60, Subtraction: 25, Division: 15"
        /// </example>
        
        [HttpGet]
        [Route("api/NumberMachine/{id}")]
        public string Get(int id)
        {
            int add = id + 20;
            int multiply = id * 2;
            int subtract = id - 20;
            int divide = id / 2;

            return $"Addition: {add}, Multiplication: {multiply}, Subtraction: {subtract}, Division: {divide}";
        } 
    }
}
