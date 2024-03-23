using Repository;
using Repository.Entities;
using Service;

namespace HuynhThienNhan_Hola
{
    public partial class CreateEmployeeForm : Form
    {

        public CreateEmployeeForm()
        {
            InitializeComponent();
        }

        private void CreateEmployeeForm_Load(object sender, EventArgs e)
        {
            Service.DepartmentService departmentService = new Service.DepartmentService();
            Service.EmployeeService employeeService = new Service.EmployeeService();
            Service.SkillService skillService = new Service.SkillService();

            List<Skill> skillList = skillService.GetSkills();
            List<Department> departments = departmentService.GetDepartmentsService();
            List<Employee> employees = employeeService.GetPositionService();

            cbxPosition.Items.Clear();
            foreach (var position in employees)
            {
                cbxPosition.Items.Add(position.Position);
            }
            cbxDepartment.Items.Clear();
            foreach (var department in departments)
            {
                cbxDepartment.Items.Add(department.DepartmentName);
            }
            foreach (var skill in skillList)
            {
                lbSkills.Items.Add(skill.SkillName);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            employee.Name = txtEmployeeName.Text;
            employee.Dob = dtpDateBirth.Value;
            employee.HireDate = dtpDateBirth.Value;

            if (cbxDepartment.SelectedItem != null && cbxDepartment.SelectedItem is Department department)
            {
                employee.DepartmentId = department.DepartmentId;
            }
             
            EmployeeService service = new EmployeeService();
            service.AddEmployee(employee);

            // L?y danh sách k? n?ng ?ã ch?n t? checkedListBoxSkills
            foreach (var selectedItem in lbSkills.SelectedItems)
            {
                if (selectedItem is Skill skill)
                {
                    // T?o m?t ??i t??ng EmployeeSkill m?i và gán giá tr?
                    EmployeeSkill employeeSkill = new EmployeeSkill();
                    employeeSkill.EmployeeId = employee.EmployeeId;
                    employeeSkill.SkillId = skill.SkillId;
                    // C?n nh?p thêm ProficiencyLevel và AcquiredDate t? giao di?n ho?c m?c ??nh

                    // Thêm EmployeeSkill vào c? s? d? li?u
                    service.AddEmployeeSkill(employeeSkill);
                }
            }

        }
    }
}
