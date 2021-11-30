using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_essentials
{
    class customer

    {
        string name, id, address, contactNumber, adharNumber, pancardNumber, emailId;

        public customer ( string name, string adhar, string pancard)
        {
            this.name = name;
            this.adharNumber = adhar;
            this.pancardNumber = pancard;
        }
        
        public customer (string name, string adhar, string pancard, string contactNumber): this(name,adhar, pancard)
        {
            this.contactNumber = contactNumber;
        }

        public customer ( string name, string adhar, string pancard, string contactNumber, string emailId): this(name,adhar,pancard,contactNumber)
        {
            this.emailId = emailId;
        }
         
    }
}
