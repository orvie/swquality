using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int substract()
        {
            return FirstNumber - SecondNumber;
        }

        public int divide() 
        {
            return FirstNumber / SecondNumber;
        }

        public int multiply()
        {
            return FirstNumber * SecondNumber;
        }
    }
}
