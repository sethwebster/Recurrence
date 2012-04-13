using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recurrence.Data.Models
{
    public enum JobStatus : int
    {
        None,
        Scheduled,
        InProgress,
        Complete
    }
}