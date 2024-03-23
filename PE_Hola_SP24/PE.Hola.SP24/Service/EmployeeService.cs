using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class EmployeeService
    {
        private EmployeeRepository _repo = new EmployeeRepository();
        public List<Employee> GetPositionService()
        {
            return _repo.getposition();
        }
        public void AddEmployee(Employee employee)
        {
            _repo.Add(employee);
        }
        public void AddEmployeeSkill(EmployeeSkill employeeSkill)
        {
            _repo.AddEmployeeSkill(employeeSkill);
        }


    }
}
