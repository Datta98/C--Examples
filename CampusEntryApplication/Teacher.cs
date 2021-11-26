using System;
using System.Collections.Generic;
using System.Text;

namespace CampusEntryApplication
{
    public class Teacher : Staff
    {
        string _department;
        public Teacher(string name, string dob, string department, string designation, string mobileno, string address) : base(name, dob,designation, mobileno, address)
        {

            this._department = department;
            //this._designation = designation;
        }
    }
}
