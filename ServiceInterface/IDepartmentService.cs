using practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice.ServiceInterface
{
    public interface IDepartmentService
    {
        public List<Department> findAllDepartments();
       
    }
}
