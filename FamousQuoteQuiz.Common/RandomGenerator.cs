﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Common
{
    public class RandomGenerator
    {
        Random random = new Random();
        public int GetRandomNumber(int minNumber = 1, int maxNumber = 2)
        {
            int number = random.Next(minNumber, maxNumber);
            return number;
        }

        public string GetRandomString(int minLength = 1, int maxLength = 10)
        {
            var letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var randomLength = random.Next(minLength, maxLength);
            var result = new StringBuilder();
            for (int i = 0; i < randomLength; i++)
            {
                var randomSymbolIndex = random.Next(0, letters.Length);
                result.Append(letters[randomSymbolIndex].ToString());
            }

            return result.ToString();
        }

        public double GetRandomDouble(double minNumber = 0.00, double maxNumber = 23.99)
        {
            double hour = minNumber + (maxNumber - minNumber) * random.NextDouble();
            return hour;
        }
    }
}
