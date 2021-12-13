using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneApplication
{
    public class Photographer
    {
        public void Capture(ICamera camera)
        {
            camera.Click();
        }

        public void Capture(SmartPhone _smartPhone)
        {
           _smartPhone.TakePicture();
        }



    }
}
