using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMPLE
{
    class tdsmodel
    { 
        private string trade_id;
        private string trade_value;
        private string counterparty_id;

        public string GetId() { return this.trade_id ;}
        public string GetValue() { return this.trade_value; }
        public string GetCid() { return this.counterparty_id; }

        public void SetId(string value)
        { this.trade_id = value; }
        public void SetValue ( string value)
        { this.trade_value = value; }
        public void SetCid( string value)
        { this.counterparty_id = value;
        }
    }
}
