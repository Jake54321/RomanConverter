using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RomanNumeralGenerator.Models;

namespace RomanNumeralGenerator.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(string input)
        {
            if (NumeralGenerator.DetermineInputType(input) == NumeralGenerator.InputType.Arabic)
                return NumeralGenerator.ConvertToNumeral(input);

            if (NumeralGenerator.DetermineInputType(input) == NumeralGenerator.InputType.Numeral)
                return NumeralGenerator.ConvertToArabic(input);

            return "There was a problem with the controller call.";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
