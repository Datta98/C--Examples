using System;
using System.Collections.Generic;
using System.Text;

namespace CampusEntryApplication
{
    public class Guest : Person
    {

        string _appointmentby;
       

        public Guest( string name, string address, string appointmentby):base(name,address)
        {
            this._appointmentby = appointmentby;
        }
       public Guest ( string name, string dob, string appointmentby, string address):base(name,dob,address)
        {
            this._appointmentby = appointmentby;
        }
        public Guest(string name, string dob,string mobileno, string appointmentby, string address) : base(name, dob, mobileno ,address)
        {
            this._appointmentby = appointmentby;
        }
    }
}
