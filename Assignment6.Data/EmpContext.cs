using Assignment6.Data.Entity_Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Data
{
    public class EmpContext : DbContext
    {
        public EmpContext() : base("name=EmpString")
        {

        }

        public DbSet<Employee1> Emp1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
