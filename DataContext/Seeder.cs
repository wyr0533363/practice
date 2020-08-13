using practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice.DataContext
{
    public class Seeder
    {
        public Seeder (ProjectContext dbContext)
        {
            Department d1 = new Department();
            d1.deptname = "Java";


            Department d2 = new Department();
            d2.deptname = "SQL";

            dbContext.Add(d1);
            dbContext.Add(d2);
            dbContext.SaveChanges();

            Employee e1 = new Employee();
            e1.name = "Mary";
            e1.password = "123";
            e1.DepartmentId = 1;
            e1.email = "mary@gmail.com";

            Employee e2 = new Employee();
            e2.name = "John";
            e2.password = "123";
            e2.DepartmentId = 1;
            e2.email = "john@gmail.com";

            Employee e3 = new Employee();
            e3.name = "Peter";
            e3.password = "123";
            e3.DepartmentId = 2;
            e3.email = "peter@gmail.com";

            dbContext.Add(e1);
            dbContext.Add(e2);
            dbContext.Add(e3);
            dbContext.SaveChanges();
        }
    }
}
