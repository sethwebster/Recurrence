using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Recurrence.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        public DateTimeOffset When { get; set; }
        /// <summary>
        /// GET, POST, PUT
        /// </summary>
        public string Method { get; set; }
        public Uri Endpoint { get; set; }
        public JobStatus Status { get; set; }
        public int Attempts { get; set; }
    }
}