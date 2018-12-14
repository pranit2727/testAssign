using System;

namespace Question1
{
    public class Calculator
    {
        //Calculating Sum of two Numbers
        public virtual int Calculate(int num1, int num2)
        {
            return (num1 + num2);
        }
    }
    public class ChildClass : Calculator
    {
        //Overiding the base implementation and Calculating multiplication of two Numbers
        public override int Calculate(int num1, int num2)
        {
            return num1 * num2;
        }
    }
    
}


