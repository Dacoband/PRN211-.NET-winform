﻿using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int? ManagerId { get; set; }

        public virtual Employee? Manager { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
