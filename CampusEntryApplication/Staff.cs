using System;
using System.Collections.Generic;
using System.Text;

namespace CampusEntryApplication
{
   public class Staff : Person
    {
        string _designation;
        


         public Staff (string name,string designation, String address):base(name,address)
        {
            this._designation = designation;
        }
            
        public Staff(string name, string dob, string designation,  string address) : base (name,address,dob)
        {
            this._designation= designation;
        }
        public Staff(string name, string dob, string designation, string mobileno, string address) : base(name,dob,mobileno, address)
        {
            this._designation = designation;
        }
    }
}
