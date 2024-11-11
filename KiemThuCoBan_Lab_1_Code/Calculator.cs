using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemThuCoBan_Lab_1_Code
{
    public class Calculator
    {
        /// <summary>
        /// Sum of two numbers
        /// </summary>
        /// <param name="theiFirstNumber">First number</param>
        /// <param name="theiSecondNumber">Second number</param>
        /// <returns></returns>
        public int Add(int theiFirstNumber, int theiSecondNumber)
        {
            return theiFirstNumber + theiSecondNumber;
        }
        /// <summary>
        /// Subtract of two numbers
        /// </summary>
        /// <param name="theiFirstNumber">First number</param>
        /// <param name="theiSecondNumber">Second number</param>
        /// <returns></returns>
        public int Subtract(int theiFirstNumber, int theiSecondNumber)
        {
            return theiFirstNumber - theiSecondNumber;
        }
        /// <summary>
        /// Calculate factorial of number
        /// </summary>
        /// <param name="theiNumber"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public int Factorial(int theiNumber)
        {
            if(theiNumber < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int aiResult = 1;
            for (int i = 1; i <= theiNumber; i++)
            {
                aiResult *= i;
            }
            return aiResult;
        }
    }
}
