using Microsoft.EntityFrameworkCore;
using practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice.DataContext
{
    public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options): base(options)
        {

        }

        public DbSet<Employee> Employee_Table { get; set; }
        public DbSet<Department> Department_Table { get; set; }
    }
}
