using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting
{
    static class NumParser
    {
        public static string NormilizeNumberToString(long number)
        {
            if(number == 0)
            {
                return "0";
            }
            bool isNegativ = number < 0;
            number = Math.Abs(number);
            string result = "";
            long sign = 0;
            int k = 0;
            while(number > 0)
            {
                sign = number % 10;
                number /= 10;
                result += sign.ToString();
                k++;
                if(k % 3 == 0 & number != 0)
                {
                    result += " ";
                }
            }
            if(isNegativ)
            {
                result += "-";
            }
            return new string(result.Reverse().ToArray());
        }

        public static string NormilizeNumberToString(string number)
        {
            if (number == "0")
            {
                return number;
            }
            string result = "";
            for(int i = 0; i < number.Length; i++)
            {
                result += number[i];
                if (i % 3 == 0 & i != number.Length - 1 & number[i] != '-')
                {
                    result += " ";
                }
            }
            return new string(result.Reverse().ToArray());
        }

        public static bool TryParseFromNormalStringToLong(string number, out long num)
        {
            string numberWithoutSpaces = number.Replace(" ", "");
            bool resultStatus = long.TryParse(numberWithoutSpaces, out num);
            return resultStatus;
        }
    }
}
