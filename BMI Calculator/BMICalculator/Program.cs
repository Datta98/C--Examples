using System;
using System.IO;

namespace BMICalculatorApplication
{
    public enum options
    {
        ConsoleInput = 1, FileInput
    }

    class Program
    {
        static void Main(string[] args)
        {
            int repeatableCount = 3;
            options choice = default;
            //  options choice =(options)choiceValue;
            do {
                string displaymessage = $"Enter Your Choice \n {(int)options.ConsoleInput}->console Input \n {(int)options.FileInput }->File Input";
                Console.WriteLine(displaymessage);

                try
                {
                    choice = (options)Int32.Parse(Console.ReadLine());
                    int  choiceValue  = Int32.Parse(Console.ReadLine());
                    
                   
                    if(choiceValue < 1 || choiceValue >2 )
                    {
                        Console.WriteLine("Invalid Option");
                    }
                    else
                    {
                        break;
                    }

                }

                catch (FormatException e)
                {
                    Console.WriteLine("Choice Must be a Number");           
                }
                --repeatableCount;
            } while (repeatableCount > 0);

            switch (choice)
                    {
                        case options.ConsoleInput:

                            BMIUserInputLib.UserInputs userInputs = new BMIUserInputLib.UserInputs();


                            BMIValueCalculationLib.BmiValueCalculation value = new BMIValueCalculationLib.BmiValueCalculation();
                            double BmiValue = value.Calculator(userInputs.GetUserHeight(), userInputs.GetUserWeight());

                            BMIValueValidationLib.BmiValueValidation validate = new BMIValueValidationLib.BmiValueValidation();
                            string message = validate.CheckBmiValue(BmiValue);

                            BMIResultDisplayLib.MessageDisplay result = new BMIResultDisplayLib.MessageDisplay();
                            result.Display(message);
                            Console.ReadKey();
                            break;



                        case options.FileInput:


                            string line;
                            System.IO.StreamReader file = new StreamReader(@"C:\Users\shridatta.r\Documents\Datta\PatientDeatails.txt");

                            while ((line = file.ReadLine()) != null)
                            {
                                string[] lineArray = { };
                                lineArray = line.Split(',');
                                string name = lineArray[0];
                                double height = double.Parse(lineArray[1]);
                                double weight = double.Parse(lineArray[2]);




                                BMIValueCalculationLib.BmiValueCalculation _value = new BMIValueCalculationLib.BmiValueCalculation();
                                double _BmiValue = _value.Calculator(height, weight);
                                BMIValueValidationLib.BmiValueValidation _validate = new BMIValueValidationLib.BmiValueValidation();
                                string _Result = _validate.CheckBmiValue(_BmiValue);
                                Console.WriteLine("Name   Height   Weight            Result");
                                Console.WriteLine(name + "    " + height + "          " + weight + "             " + _Result);
                            }

                            break;
                            file.Close();
                    }


               


           

        }
    }

}

