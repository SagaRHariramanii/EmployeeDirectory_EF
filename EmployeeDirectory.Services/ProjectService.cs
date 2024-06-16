using AutoMapper;
using EmployeeDirectory.Data;
using EmployeeDirectory.Data.Contract;
using EmployeeDirectory.Models;
using EmployeeDirectory.Services.Contract;

namespace EmployeeDirectory.Services
{
    public class ProjectService : IProjectService
    {
        readonly IProjectHandler _projectHandler;
        readonly IMapper _mapper;
        public ProjectService(IProjectHandler projectHandler,IMapper mapper)
        {
            this._projectHandler = projectHandler;
            this._mapper = mapper;
        }
        public List<Project> GetProjects()
        {
            var projects = _mapper.Map<List<Data.Models.Project>, List<Models.Project>>(_projectHandler.GetData());
            return projects;
        }
        public string? GetProjectName(int? id)
        {
            return _projectHandler.GetProjectNameById(id);
        }
    }
}
