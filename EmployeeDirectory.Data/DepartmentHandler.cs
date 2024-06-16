using EmployeeDirectory.Data.Contract;
using EmployeeDirectory.Data.Models;

namespace EmployeeDirectory.Data
{
    public class DepartmentHandler : IDepartmentHandler
    {
        public List<Department> GetData()
        {
            using(var context= new SagarEmployeeDirectoryDbContext())
            {
                List<Department> departments= context.Departments.ToList();
                return departments;
            }
        }
        public Department? GetDepartmentById(int id)
        {
            using (var context= new SagarEmployeeDirectoryDbContext())
            {
                Department? department= context.Departments.SingleOrDefault(d => d.Id == id);
                return department;
            }
        }
        public string? GetDepartmentNameById(int id)
        {
            string? departmentName;
            using (var context = new SagarEmployeeDirectoryDbContext())
            {
                departmentName= context.Departments.SingleOrDefault(d=> d.Id == id)!.Name;
                return departmentName;
            }
        }
    }
}
