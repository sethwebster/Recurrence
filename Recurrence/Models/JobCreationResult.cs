using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recurrence.Models
{
    public class JobCreationResult : ResultModel
    {
        public Job Job { get; set; }
        public bool CreationSuccessful { get; set; }
    }
}