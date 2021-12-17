using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent _observer_parent = new Parent();
            JobstatusHandler _addressOfNotify = new JobstatusHandler(_observer_parent.Notify);

            Friend _observer_friend = new Friend();
            JobstatusHandler _addressofUpdate = new JobstatusHandler(_observer_friend.Update);



            Child _elder = new Child();
            //Subscribe
             _elder.OnJobStatusChanged += _addressOfNotify; //Add_observer
             _elder.OnJobStatusChanged+= _addressofUpdate; //Add_observer
             
            //_elder.Add_Observer(_addressofUpdate);
            //_elder.Add_Observer(_addressOfNotify);
            _elder.GotNewJob();
          

            Child _young = new Child();
            _young.GotNewJob();

        }
    }
}
