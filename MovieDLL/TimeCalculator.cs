using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDLL
{
    public class TimeCalculator
    {
        public int ConvertLengthInMinutesToSeconds(int _minutes)
        {
            if (_minutes == 0 || _minutes < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return _minutes * 60;
        }
    }
}
