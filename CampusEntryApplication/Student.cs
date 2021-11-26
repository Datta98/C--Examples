using System;
using System.Collections.Generic;
using System.Text;

namespace CampusEntryApplication
{
   public  class Student : Person 
    {
        string _rollno, _branch;

        public Student(string name, string dob, string rollno, string branch, string mobileno, string address) : base(name, dob, mobileno, address)
        {
            this._rollno = rollno;
            this._branch = branch;
        }

    }
}
