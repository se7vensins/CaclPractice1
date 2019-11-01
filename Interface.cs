using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaclPractice1
{
    public interface ICalc
    {
        int add(int num1, int num2);

        int sub(int num1, int num2);

        int div(int num1, int num2);

        int mult(int num1, int num2);

    }
}
