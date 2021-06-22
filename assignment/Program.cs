using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMPLE
{
    class Program
    {
        static void Main(string[] args)
        {
            tdsmodel tds = new tdsmodel();
            tds.SetId("22");
            tds.SetValue("12000");
            string tradeid = tds.GetId();
            string tradevalue = tds.GetValue();

            Rdsmodel rds = new Rdsmodel();
            rds.SetCId("0025");
            rds.SetCN(" XYZ ");
            string counterpartyid = rds.GetCId();
            string counterpartyname = rds.GetCName();
        }
    }
}
