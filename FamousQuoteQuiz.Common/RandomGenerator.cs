using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Common
{
    public class RandomGenerator
    {
        Random random = new Random();

        /// <summary>
        /// Return random integer in range [minNumber, maxNumber]
        /// </summary>
        /// <param name="minNumber"></param>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        public int GetRandomNumber(int minNumber, int maxNumber)
        {
            int number = random.Next(minNumber, maxNumber + 1);
            return number;
        }
    }
}
