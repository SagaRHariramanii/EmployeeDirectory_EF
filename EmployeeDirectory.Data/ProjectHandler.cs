using EmployeeDirectory.Data.Contract;
using EmployeeDirectory.Data.Models;
using Microsoft.Data.SqlClient;

namespace EmployeeDirectory.Data
{
    public class ProjectHandler : IProjectHandler
    {
        public List<Project> GetData()
        {
            using (var context = new SagarEmployeeDirectoryDbContext())
            {
                List<Project> projects = context.Projects.ToList();
                return projects ;
            }
        }
        public string? GetProjectNameById(int? id)
        {
            string? projectName;
            if (id == null)
            {
                return null;
            }
            else
            {
                using (var context = new SagarEmployeeDirectoryDbContext())
                {
                    projectName = context.Projects.SingleOrDefault(p => p.Id == id)!.Name;
                    return projectName;
                }
            }
           

        }
    }
}
