using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadInputData inputData = new ReadInputData();
            double num1 = inputData.Input1();
            double num2 = inputData.Input2();
            string mathoperator = inputData.MathOperator();

            Calculator _calculator = new Calculator();
            _calculator.Calculation(num1, num2, mathoperator);
        }
    }
    class ReadInputData
    {
        public double Input1()
        {
            
                System.Console.WriteLine("Enter your First Number");
                double  Firstnum = Convert.ToDouble(Console.ReadLine());
                return Firstnum;
        }
        public double Input2()
        {
            System.Console.WriteLine("Enter your Second Number ");
            double Secondnum = Convert.ToDouble(Console.ReadLine()); 
            return Secondnum;
        }
        public string MathOperator()
        {

            Console.Write("Please enter an operand (+, -, /, *): ");
          string  operand = Console.ReadLine();
            return operand;
        }

    }

    class Calculator
    {
        //private double num1;
        //private double num2;
        //private string mathoperator;
        private double answer;

        public void Calculation(double num1, double num2, string mathoperator)
        {
            //this.num1 = num1;
            //this.num2 = num2;
            //this.mathoperator = mathoperator;
                      
                switch (mathoperator)
                {
                    case "":
                         Console.WriteLine("Invalid Input");
                         break;

                    case "-":
                        answer = num1 - num2;
                        this.Display(num1, num2, mathoperator);
                        break;

                    case "+":
                        answer = num1 + num2;
                        this.Display(num1, num2, mathoperator);
                        break;

                    case "/":
                        answer = num1 / num2;
                        this.Display(num1, num2, mathoperator);
                        break;

                    case "*":
                        answer = num1 * num2;
                        this.Display(num1, num2, mathoperator);
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
               
                Console.ReadLine();          

        }

        public void Display(double num1, double num2, string mathoperator)
        {
            Console.WriteLine(num1.ToString() + " " + mathoperator + " " + num2.ToString() + " = " + answer.ToString());
        }
    }
}
