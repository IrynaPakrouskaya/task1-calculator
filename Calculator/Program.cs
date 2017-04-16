using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            int operation = 1;
            double result;
            int inputStatusCode; // 0 - valid, 1 - invalid

            do{
                    Console.Write("Enter number: ");
                    try
                        {
                            num1 = Convert.ToDouble(Console.ReadLine());
                            inputStatusCode = 0;
                        }
                    catch(Exception)
                        {
                            inputStatusCode = 1;    
                            Console.WriteLine("Input is invalid. Try again.");
                            Console.ReadLine();
                            Console.Clear();                
                        }
            } while (inputStatusCode == 1);

            do{
                    Console.WriteLine("Select operation: \n 1 : + \n 2 : - \n 3 : * \n 4 : / \n");
                    try
                    {
                        operation = Convert.ToInt32(Console.ReadLine());
                        if(operation > 4 || operation < 1)
                        {
                            throw new Exception();
                        }
                        inputStatusCode = 0;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Input is invalid. Try again.");
                        inputStatusCode = 1;
                    }
            } while (inputStatusCode == 1);

            do{
                    Console.Write("Enter number: ");
                    try
                    {
                        num2 = Convert.ToDouble(Console.ReadLine());
                        if(num2 == 0 && operation == 4)
                        {
                            throw new Exception();
                        }
                        inputStatusCode = 0;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Input is invalid. Try again.");
                        inputStatusCode = 1;
                    }
            } while (inputStatusCode == 1);
            

            result = Calculator.Calculate(num1, num2, operation);
            Console.Write("Result = {0}", result);            

            Console.ReadLine();
        } 
     }
    static class Calculator
    {
        public static double Calculate(double num1, double num2, int operation)
        {
            double result;
            switch (operation)
            {
                case 1:
                    {
                        result = num1 + num2;
                        break;
                    }
                case 2:
                    {
                        result = num1 - num2;
                        break;
                    }
                case 3:
                    {
                        result = num1 * num2;
                        break;
                    }
                case 4:
                    {
                        result = num1 / num2;
                        break;
                    }
                default:
                    {
                        result = 0;
                        Console.WriteLine("Invalid operation code.");
                        break;
                    }
            }
            return result;
        }
    }  
}
