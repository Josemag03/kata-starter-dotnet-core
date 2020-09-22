using System;

namespace Kata
{
    public class Calculator
    {
        public int Add(string number = "")
        {
            int value = 0;
            try
            {
                if (number.Contains(","))
                {
                    string[] numbers = number.Split(",");

                    foreach (var data in numbers)
                    {
                        value += Convert.ToInt32(data);
                    }
                }
                else
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