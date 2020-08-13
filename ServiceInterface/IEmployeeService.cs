using practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice.ServiceInterface
{
    public interface IEmployeeService
    {
        public List<Employee> findAllEmployees();
        public Employee findEmployeeById(int empid);
        public List<Employee> findEmployeeByDeptName(String name);
        public Boolean saveEmp(Employee employee);
    }
}
