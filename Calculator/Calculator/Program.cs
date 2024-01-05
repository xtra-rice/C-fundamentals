using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|             CALCULATOR             |");
            Console.WriteLine("-------------------------------------");

            Logic myObj = new Logic();


            while (true)
            {
                Console.Write("Enter operation: " +
                    "1.Addition " +
                    "2.Subtraction " +
                    "3.Multiplication " +
                    "4.Division " +
                    "5.Quit: ");

                if (!int.TryParse(Console.ReadLine(), out int operation) || operation < 1 || operation > 5)
                {
                    Console.Write("Invalid operation. Please enter a valid option (1-5). \n\n");
                    continue;
                }

                if (operation == 5)
                {
                    Environment.Exit(0);
                }


                while (true)
                {
                    Console.Write("Enter the 1st number: ");
                    if (!float.TryParse(Console.ReadLine(), out float n1))
                    {
                        Console.WriteLine("Invalid number. Please enter a valid number.\n");
                        continue;
                    }

                    Console.Write("Enter the 2nd number: ");
                    if (!float.TryParse(Console.ReadLine(), out float n2))
                    {
                        Console.WriteLine("Invalid number. Please enter a valid number.\n");
                        continue;
                    }


                    switch (operation)
                    {
                        case 1:
                            myObj.Add(n1, n2);
                            break;

                        case 2:
                            myObj.Subtract(n1, n2);
                            break;

                        case 3:
                            myObj.Multiply(n1, n2);
                            break;

                        case 4:
                            myObj.Divide(n1, n2);
                            break;
                    }
                    break;
                }
            }
        }
    }
}