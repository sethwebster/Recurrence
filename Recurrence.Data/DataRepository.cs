using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Recurrence.Data.Models;

namespace Recurrence.Data
{
    public class DataRepository : DbContext, IDataRepository
    {
        public DbSet<Job> Jobs { get; set; }
    }
}