using practice.Models;
using practice.Repo;
using practice.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice.ServiceImpl
{
    public class DepartmentServiceImpl : IDepartmentService
    {
        public IDepartmentRepo drepo;

        public DepartmentServiceImpl(IDepartmentRepo drepo)
        {
            this.drepo = drepo;
        }
        public List<Department> findAllDepartments()
        {
            List<Department> dlist = drepo.findAllDepartments();
            return dlist;
        }
    }
}
