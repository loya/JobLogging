﻿using System;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Linq;

namespace JobLogging.JobLoggingModel
{
    public partial class JobLoggingModelContainer
    {
        public JobLoggingModelContainer(string connectionstring) : base(connectionstring)
        {
            
        }
        public override int SaveChanges()
        {
            var entries = this.ChangeTracker.Entries().Where(e => e.State == System.Data.EntityState.Modified && e.Entity is JobOrder);
            foreach (var dbEntityEntry in entries)
            {
                var entity = (JobOrder)dbEntityEntry.Entity;
                entity.ModifyBy = GlobalParams.CurrentLoginUser.Name;
                entity.ModifyDate = DateTime.Now;}
            return base.SaveChanges();
        }
    }
}
