using practice.DataContext;
using practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice.Repo
{
    public interface IDepartmentRepo
    {
        public List<Department> findAllDepartments();
    }
    public class DeparmentRepo : IDepartmentRepo
    {
        private ProjectContext _context;
        public DeparmentRepo(ProjectContext _context)
        {
            this._context = _context;
        }

        public List<Department> findAllDepartments()
        {
            List<Department> dlist = _context.Department_Table.ToList();
            return dlist;
        }
    }
}
