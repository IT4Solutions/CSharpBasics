using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class MyMath
    {
        public DateTime date { get; set; }
        public string OperatedBy { get; set; }

        public MyMath()
        {
            // init
            date = DateTime.Now.Date;
            OperatedBy = "Raouf Yasin";
        }


        public decimal Caculation(int FirstNumber, int SecondNumber, string Operator)
        {
            decimal result = 0.0m;

            if (Operator == "+")
            {
                result = FirstNumber + SecondNumber;
            }
            else if (Operator == "-")
            {
                result = FirstNumber - SecondNumber;
            }
            else if (Operator == "*")
            {
                result = FirstNumber * SecondNumber;
            }
            else if (Operator == "/")
            {
                result = FirstNumber / SecondNumber;
            }
            else
            {
                result = FirstNumber % SecondNumber;
            }

            return result;
            
        }
    }
}
