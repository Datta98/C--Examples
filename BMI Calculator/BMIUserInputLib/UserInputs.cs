using System;

namespace BMIUserInputLib
{
    public class UserInputs
    {
        public double GetUserHeight()
        {
            //Console.WriteLine("Enter your height in meter:");
            //double height = Convert.ToDouble((Console.ReadLine()));
            //return height;


            double height = Convert.ToDouble(this.ReadFromConsole("Enter your height in Feet:"));
            return height;
        }

        public double GetUserWeight()
        {
            //    Console.WriteLine("Enter your weight in Kg:");
            //    double weight = Convert.ToDouble((Console.ReadLine()));
            //    return weight;


            double weight = Convert.ToDouble(this.ReadFromConsole("Enter your weight in kg:"));
            return weight;

        }
       
         private string ReadFromConsole(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

    }
}
