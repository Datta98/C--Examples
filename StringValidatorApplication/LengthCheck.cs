using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidatorApplication
{
    public class LengthCheck : IValidate
    {
        public bool IsValidString(string data)
        {
            if (data.Length > 8)
            {
                return false;
            }
            return true;
        }
    }
}
