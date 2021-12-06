using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProduction
{
    class Program
    {
        static void Main(string[] args)
        {
            TATACar nexon = new TATACar();
            nexon.TataCar(new VeriCorEngine());            
            nexon.Drive();
            nexon.Halt();


            TATACar harrier = new TATACar();
            harrier.TataCar(new MultiJetEngine());            
            harrier.Drive();
            harrier.Halt();


            TATACar hexa = new TATACar();
            hexa.TataCar(new RevorTron());            
            hexa.Drive();
            hexa.Halt();


            //IEngine  e;

            //e = new MultiJetEngine();




        }


    }

   

}
