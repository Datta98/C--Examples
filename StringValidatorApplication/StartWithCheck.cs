using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidatorApplication
{
    public class StartWithCheck : IValidate
    {
        public bool IsValidString(string data)
        {
            if (data.StartsWith("ex"))
            {
                return false;
            }
            return true;
        }
    }
}
