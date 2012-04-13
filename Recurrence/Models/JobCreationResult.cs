using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Recurrence.Data.Models;

namespace Recurrence.Models
{
    public class JobCreationResult : ResultModel
    {
        public Job Job { get; set; }
        public bool CreationSuccessful { get; set; }
    }
}