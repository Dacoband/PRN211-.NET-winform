using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class SkillService
    {
        private EmployeeRepository _repo = new EmployeeRepository();
        public List<Skill> GetSkills()
        {
            return _repo.getskill();
        }

    }
}
