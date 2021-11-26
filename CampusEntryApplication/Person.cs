using System;
using System.Collections.Generic;
using System.Text;

namespace CampusEntryApplication
{
   public abstract class Person
    {
        
        private string _name, _dob, _mobileno, _address;
        public Person(string name, String address)
        {
            this._name = name;
            this._address = address;
        }
        public Person(string name, string address, string dob) : this(name,address)
        {
            this._dob = dob;
        }
        public Person(string name ,string dob,  string mobileno, string address ) : this(name, address,dob)
        {
            this._mobileno = mobileno;
        }
        //public Person(string name, string dob, string mobileno, string address) : this(name, dob, mobileno)
        //{
        //    this._address = address;
        //}
    }
}
