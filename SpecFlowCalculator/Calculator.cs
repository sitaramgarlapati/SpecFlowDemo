using System;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            //throw new NotImplementedException();
            return FirstNumber + SecondNumber;
        }

        public int Subtract()
        {
            //throw new NotImplementedException();
            //return 0;
            return FirstNumber - SecondNumber;
        }

    }
}
