using System;

namespace CaclPractice1
{
    public class CalcImplement:ICalc
    {
        public int add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public int sub(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public int div(int num1, int num2)
        {
            int result = num1 / num2;
            if (result == 0)
            {
                Console.WriteLine("Error Message zero number divided");
            }
            else
            {
                return result;
            }
            return result;
        }
        public int mult(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
    }
}
