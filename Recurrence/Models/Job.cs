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
        [Required]
        public DateTimeOffset When { get; set; }
        /// <summary>
        /// GET, POST, PUT
        /// </summary>
        [Required]
        public string Method { get; set; }
        [Required]
        public string Endpoint { get; set; }        
        public int StatusValue { get; set; }
        public JobStatus Status
        {
            get
            {
                return (JobStatus)StatusValue;
            }
            set
            {
                StatusValue = (int)value;
            }
        }

        public int Attempts { get; set; }
    }
}