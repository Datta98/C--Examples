using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMPLE
{
    class Rdsmodel
    {
        private string Counterparty_id;
        private string Counterparty_name;

        public string GetCId() { return this.Counterparty_id; }
        public string GetCName() { return this.Counterparty_name; }

        public void SetCId (string value)
        { this.Counterparty_id = value; }
        public void SetCN ( string value)
        { this.Counterparty_name = value; }
            
    }
}
