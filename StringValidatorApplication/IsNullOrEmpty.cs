using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidatorApplication
{
    public class IsNullOrEmpty : IValidate
    {
        public bool IsValidString(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return false;
            }
            return true;
        }
    }
}
