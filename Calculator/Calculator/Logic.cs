using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Logic
    {
        public void Add(float n1, float n2)
        { 

            float result = n1 + n2;
            Console.WriteLine($"{n1} + {n2} = {result}\n");
        }
            
        public void Subtract(float n1, float n2)
        {
            float result = n1 - n2;
            Console.WriteLine($"{n1} - {n2} = {result}\n");
        }

        public void Multiply(float n1, float n2)
        {
            float result = n1 * n2;
            Console.WriteLine($"{n1} * {n2} = {result}\n");
        }

        public void Divide(float n1, float n2)
        {
            if(n2 != 0)
            {
                float result = n1 / n2;
                float roundOff = (float)Math.Round(result, 2);
                Console.WriteLine($"{n1} / {n2} = {roundOff}\n");
            }
            else
            {
                Console.WriteLine("Cannot divide by 0\n");
            }
           
        }
    }
}
