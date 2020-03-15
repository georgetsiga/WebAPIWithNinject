using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIWithNinject.Controllers
{
    public class AverageController : ApiController
    {
        private readonly IAverage _average;
        public AverageController(IAverage average)
        {
            _average = average;
        }
        [HttpPost]
        public int GetAverage(List<int> numbers)
        {
            return _average.GetAverage(numbers);
        }
    }
}