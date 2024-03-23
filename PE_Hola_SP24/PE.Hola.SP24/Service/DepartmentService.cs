using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    
    public class DepartmentService
    {
        private EmployeeRepository _repo = new EmployeeRepository();
        public List<Department> GetDepartmentsService()
        {
            return _repo.GetDepartmentss();
        }
    }
}
