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

                if (number.Contains("\n"))
                {
                    string[] numbersNewLine = number.Split("\n");
                    string[] numbers2 = numbersNewLine[1].ToString().Split(",");
                    int count=0;
                    foreach (var data in numbersNewLine)
                    {
                        count++;
                        if(count==1)
                        value += Convert.ToInt32(data);
                    }

                    value = SumValues(value, numbers2);
                }
                else if (number.Contains(","))
                {
                    string[] numbers = number.Split(",");

                    value = SumValues(value, numbers);
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

        private static int SumValues(int value, string[] numbers)
        {
            foreach (var data in numbers)
            {
                value += Convert.ToInt32(data);
            }

            return value;
        }
    }
}