using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProgram
{
    public delegate void JobstatusHandler(string status);


   public class Child
    {
        string jobStatus = "UnEmployeed";
        public event JobstatusHandler OnJobStatusChanged;
        public void GotNewJob()
        {
            jobStatus = "Employeed";
            OnJobStatusChanged.Invoke(this.jobStatus);
        }

        //string JobStatus = "Unemployeed";
        //List<JobstatusHandler> observers = new List<JobstatusHandler>();
        //public void GotNEwJob()
        //{
        //    JobStatus = "employeed";

        //    for (int i = 0; i < observers.Count; i++)
        //    {
        //        JobstatusHandler eachObserver = observers[i];
        //        eachObserver.Invoke(this.JobStatus);
        //    }
        //}
        //public void Add_Observer(JobstatusHandler observer)
        //{
        //    observers.Add(observer);
        //}
        //public void Remove_observer(JobstatusHandler observer)
        //{
        //    observers.Remove(observer);
        //}

    }
}
