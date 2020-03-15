using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIWithNinject
{
    public class Average : IAverage
    {
        public int GetAverage(IEnumerable<int> numbers)
        {
            return numbers != null ? (int)numbers.Average() : 0;
        }
    }
}