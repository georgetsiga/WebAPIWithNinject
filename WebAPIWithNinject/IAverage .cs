using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIWithNinject
{
    public interface IAverage
    {
        int GetAverage(IEnumerable<int> numbers);
    }
}
