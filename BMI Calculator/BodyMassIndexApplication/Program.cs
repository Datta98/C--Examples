using System;

namespace BodyMassIndexApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInputs inputs = new UserInputs();



            BmiValueCalculation value = new BmiValueCalculation();
            double BmiValue = value.calculator(inputs.UserHeight(), inputs.UserWeight());


            BmiValueValidation validate = new BmiValueValidation();
            string message = validate.CheckCondition(BmiValue);

            MessageDisplay display = new MessageDisplay();
            display.Display(message);
            Console.ReadKey();


        }
    }
    class UserInputs
    {


        public double UserHeight()
        {
            double height = Convert.ToDouble(this.ReadFromConsole("Enter your height in meter:"));
            return height;
        }

        public double UserWeight()
        {
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



    public class BmiValueCalculation
    {
        private double bmivalue;

        public double calculator(double height, double weight)
        {
            bmivalue = weight / height;
            return bmivalue;
        }


    }

    class BmiValueValidation
    {

        #region Checking BMIvalue 
        public string CheckCondition(double BMIValue)
        {
            if (BMIValue < 18.5)
            {
                return "UnderWeight";
            }
            else if (BMIValue >= 25)
            {
                return "OverWeight";
            }
            else
            {
                return "Normal";
            }
        }
        #endregion

    }

   

    class MessageDisplay
    {
        #region Message display
        public void Display(string message)
        {

            Console.WriteLine(message);
        }


        #endregion
    }
}
