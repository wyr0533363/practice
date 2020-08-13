using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using practice.Models;
using practice.ServiceInterface;

namespace practice.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService eservice;
        private IDepartmentService dservice;

        public EmployeeController(IEmployeeService eservice, IDepartmentService dservice)
        {
            this.eservice = eservice;
            this.dservice = dservice;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("/employee/getallemp")]
        public IActionResult getAllEmp()
        {
            List<Employee> emplist = eservice.findAllEmployees();
            ViewData["emplisttohtml"] = emplist;
            return View();
        }

        public IActionResult Create()
        {
            List<Department> dlist = dservice.findAllDepartments();
            ViewData["dlisttohtmal"] = dlist;
            return View();
        }

        public IActionResult Save(Employee employee)
        {
            System.Diagnostics.Debug.WriteLine(employee.name);
            System.Diagnostics.Debug.WriteLine(employee.email);
            System.Diagnostics.Debug.WriteLine(employee.password);
            eservice.saveEmp(employee);
            return RedirectToAction("getallemp");
        }

        [Route("/employee/{id}")]
        public Employee getEmployeeById(int id)
        {
            Employee emp = eservice.findEmployeeById(id);
            return emp;
        }

        [Route("/emp/{dname}")]
        public List<Employee> getEmployeeByDeptName(string dname)
        {
            List<Employee> emp = eservice.findEmployeeByDeptName(dname);
            return emp;
        }

        [Route("/depts")]
        public List<Department> getAllDepartments()
        {
            List<Department> dlist = dservice.findAllDepartments();
            return dlist;
        }
    }
}