using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Recurrence.Data.Models;

namespace Recurrence.Data
{
    public interface IDataRepository : IDisposable
    {
        DbSet<Job> Jobs { get; set; }
        int SaveChanges();
    }

    public static class IDataRepositoryExtensions
    {
        public static DbEntityEntry Entry(this IDataRepository input, object entity)
        {
            return (input as DbContext).Entry(entity);
        }
    }
}
