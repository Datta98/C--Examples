using System;

namespace SmartPhoneApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera _camera = new Camera();
            GPS _gps = new GPS();
            Phone _phone = new Phone();
            Photographer _photographer = new Photographer();
            Traveller _traveller = new Traveller();
            Person _person = new Person();

            SmartPhone _smartPhone = new SmartPhone();
            _smartPhone.SetCamera(_camera);
            _smartPhone.SetGps(_gps);
            _smartPhone.SetPhone(_phone);


            _photographer.Capture(_camera);
             // Photographer can use either camera or smartphone to capture
            _photographer.Capture(_smartPhone);

            _traveller.Hike(_gps);
            // Traveller can use either Gps or smartphone
            _traveller.Hike(_smartPhone);

            _person.Communicate(_phone);
            // Person can use either phone or smartphone to communicate
            _person.Communicate(_smartPhone);

            
        }
    }

}
