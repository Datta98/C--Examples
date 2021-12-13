    using System;

namespace SmartDeviceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer _printerRef = new Printer();
            Scanner _scannerRef = new Scanner();

            PrintManager _printManager = new PrintManager();
            _printManager.PrintDocument(_printerRef);

            ScanManager _scanManager = new ScanManager();
            _scanManager.ScanDocument(_scannerRef);

            PrintScanner _printScanner = new PrintScanner();
            _printScanner.SetPrinter(_printerRef);
            _printScanner.SetScanner(_scannerRef);

            _printManager.PrintDocument(_printScanner);
            _scanManager.ScanDocument(_printScanner);
        }
    }
   

   

   


   


   
   
}
