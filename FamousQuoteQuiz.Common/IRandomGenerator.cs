using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Common
{
    public interface IRandomGenerator
    {
        int GetRandomNumber(int minNumber, int maxNumber);
    }
}
