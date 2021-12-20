using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidatorApplication
{
    public class StringValidator
    {
        IValidate _validate;
        public StringValidator(IValidate validate)
        {
            this._validate = validate;
        }

        public bool IsValidString(string data)
        {
            return _validate.IsValidString(data);


        }
    }
}
