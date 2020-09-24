using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler16
{
    public class Algorithm
    {
        private const int Base = 2;

        private const int Power = 1000;

        public int Run()
        {
            var digits = new List<int>();

            digits.Add(Base);
            int carry = 0;

            for (int pow = 2; pow < Power + 1; pow++)
            {
                for (int i = 0; i < digits.Count; i++)
                {
                    int temp = digits[i] * Base;

                    if (temp > 9)
                    {
                        digits[i] = (temp % 10) + carry;
                        carry = 1;
                        digits.Add(default(int));
                    }
                    else
                    {
                        digits[i] = temp + carry;
                        carry = 0;
                    }
                }
            }

            int sum = 0;

            for (int i = 0; i < digits.Count; i++)
            {
                sum += digits[i];
            }

            return sum;
        }
    }
}
