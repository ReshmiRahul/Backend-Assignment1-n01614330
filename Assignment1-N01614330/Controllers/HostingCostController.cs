using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01614330.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Returns the total hosting cost based on the number of days.
        /// </summary>
        /// <param name="id">The number of days elapsed</param>
        /// <returns>A string describing the total hosting cost</returns>
        /// <example>
        /// GET localhost/api/HostingCost/0 -> 
        /// "1 fortnights at $5.50/FN = $5.50 CAD
        /// HST 13% = $0.72 CAD
        /// Total = $6.22 CAD"
        /// GET localhost/api/HostingCost/14 -> 
        /// "2 fortnights at $5.50/FN = $11.00 CAD
        /// HST 13% = $1.43 CAD
        /// Total = $12.43 CAD"
        /// Get localhost/HostingCost/15 ->
        /// "2 fortnights at $5.50/FN = $11.00 CAD
        /// HST 13% = $1.43 CAD
        /// Total = $12.43 CAD"
        /// Get localhost/HostingCost/21 ->
        /// "2 fortnights at $5.50/FN = $11.00 CAD
        /// HST 13% = $1.43 CAD
        /// Total = $12.43 CAD"
        /// GET localhost/api/HostingCost/28 -> 
        /// "3 fortnights at $5.50/FN = $16.50 CAD
        /// HST 13% = $2.14 CAD
        /// Total = $18.64 CAD"
        /// </example>
        /// 
        [HttpGet]
        [Route("api/HostingCost/{id}")]
        public string Get(int id)
        {
            int fortnights = (id / 14) + 1;
            double hostCost = fortnights * 5.50;
            double hst = hostCost * 0.13;
            double totalCost = hostCost + hst;

            string costString = $"{fortnights} fortnights at $5.50/FN = ${hostCost:F2} CAD";
            string hstString = $"HST 13% = ${hst:F2} CAD";
            string totalString = $"Total = ${totalCost:F2} CAD";

            return $"{costString}\n{hstString}\n{totalString}";
        }
    }
}