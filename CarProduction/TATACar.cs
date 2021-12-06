using System;
using System.Collections.Generic;
using System.Text;

namespace CarProduction
{
    class TATACar
    {

        IEngine _engine;
      
        public void TataCar(IEngine engine)
        {

            this._engine = engine;
        }

        public void Drive()
        {

           _engine.Start();
        }
        public void Halt()
        {
            
            _engine.Stop();
        }

    }
    


   

   

   
   

}
