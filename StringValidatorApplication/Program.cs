using System;

namespace StringValidatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string data1 = null;
            string data2 = "mysore";
            string data3 = "Excel";
            StringValidator nullorempty = new StringValidator( new IsNullOrEmpty());
            nullorempty.IsValidString(data1);

            StringValidator lengthcheck = new StringValidator(new LengthCheck());
            lengthcheck.IsValidString(data2);

            StringValidator startwith = new StringValidator(new StartWithCheck());
            startwith.IsValidString(data3);
           
        }
    }
  
}
