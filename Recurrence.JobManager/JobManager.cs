using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Recurrence.Data;
using System.Timers;

namespace Recurrence.JobManager
{
    public class JobManager
    {
        IDataRepository db = null;

        Timer _jobTimer = null;
        bool _isRunning = false;

        public JobManager(IDataRepository database)
        {
            this.db = database;
            _jobTimer = new Timer();
            _jobTimer.Interval = 500;
            _jobTimer.Elapsed += new ElapsedEventHandler(OnElapsed);
            _jobTimer.Start();
        }

        void OnElapsed(object sender, ElapsedEventArgs e)
        {
            if (_isRunning)
            {
                //DO WORK
            }
        }

        public void Start()
        {
            _isRunning = true;
        }

        public void Stop()
        {
            _isRunning = false;
        }
        

    }
}
