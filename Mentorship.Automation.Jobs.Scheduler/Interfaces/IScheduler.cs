using System;
using System.Collections.Generic;
using System.Text;

namespace Mentorship.Automation.Jobs.Scheduler.Interfaces
{
    public interface IScheduler
    {
        void CreateTask();
        void DeleteTask();
        void RunTask();
        void StopTask();
        void ReturnTask();
    }
}
