using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceApplication
{
    public class ScanManager 
    {
        public void ScanDocument(IScanner scaner)
        {
            scaner.Scan();
        }
    }

}
