using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceApplication
{
    public class PrintScanner :  IPrinter,IScanner
    {
        IPrinter _printerRef;
        IScanner _scannerRef;

        public void SetPrinter(IPrinter printerRef )
        {
            this._printerRef = printerRef;
        }

        public void SetScanner(IScanner scannerRef)
        {
            this._scannerRef = scannerRef;
        }

        public void Print() { this._printerRef.Print(); }
        public void Scan() { this._scannerRef.Scan(); }
    }

}

