using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Recurrence.Models
{
    public interface IDataRepository
    {
        DbSet<Job> Jobs { get; set; }
        int SaveChanges();
    }
}
