using System;

namespace Kata
{
    public class Calculator
    {
        public int Add(string number ="")
        {
            int value = 0;
            try
            {
                 value = Convert.ToInt32(number);
            }
            catch (Exception ex)
            {
                value = 0;
            }

            return value;
        }

        
    }
}