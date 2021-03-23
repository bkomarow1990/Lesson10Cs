using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lesson10Cs
{
    class Iterator 
    {

        public IEnumerable<int> GetNumsToSumm(int summ)
        {
            int[] tmp = new int[2];
            tmp[0] = 0;
            tmp[1] = 1;
            int sum = 0;
            yield return 0;
            yield return 1;
            while (true) { 
                sum = tmp[0] + tmp[1];
                tmp[0] = tmp[1];
                tmp[1] = sum;
                if (sum <= summ)
                {
                    yield return sum;
                }
                else { break; }
                
            }
        }
        public IEnumerable<string> Converting(int bits)
        {
            //for (int i = 0; i < Math.Pow(2,bits); i++)
            //{
            //    Console.WriteLine(i);
            //    yield return Convert.ToString(i,3);
            //}
            yield return "2";
        }
    }
}
