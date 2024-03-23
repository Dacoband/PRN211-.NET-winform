using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeRepository
    {
        private PE_Hola_SP24Context _context;
        public List<Department> GetDepartmentss()
        {
            _context = new();
            return _context.Departments.ToList();
        }
        public List<Employee> getposition()
        {
            _context = new();
            return _context.Employees.ToList();
        }
        public List<Skill> getskill()
        {
            _context = new();
            return _context.Skills.ToList();
        }

        public void Add(Employee employee)
        {
            _context = new();
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void AddEmployeeSkill(EmployeeSkill employeeSkill)
        {
            _context = new();
            _context.EmployeeSkills.Add(employeeSkill);
            _context.SaveChanges();
        }

    }
}
