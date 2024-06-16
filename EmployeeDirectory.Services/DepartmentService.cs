using AutoMapper;
using EmployeeDirectory.Data.Contract;
using EmployeeDirectory.Models;
using EmployeeDirectory.Services.Contract;

namespace EmployeeDirectory.Services
{
    public class DepartmentService : IDepartmentService
    {
        IDepartmentHandler _departmentHandler;
        IMapper _mapper;
        public DepartmentService(IDepartmentHandler departmentHandler,IMapper mapper)
        {
            _departmentHandler = departmentHandler;
            _mapper = mapper;
        }
        public List<Department> GetDepartments()
        {
            var departments = _mapper.Map<List<Data.Models.Department>, List<Models.Department>>(_departmentHandler.GetData());
            return departments;
        }
        public string? GetDepartmentName(int id)
        {
            return _departmentHandler.GetDepartmentNameById(id);
        }
        public Department? GetDepartmentById(int id)
        {
            var department = _mapper.Map<Data.Models.Department, Models.Department>(_departmentHandler.GetDepartmentById(id)!);
            return department;
        }
    }
}
