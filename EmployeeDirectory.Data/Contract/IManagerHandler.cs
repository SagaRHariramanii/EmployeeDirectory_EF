using EmployeeDirectory.Data.Models;

namespace EmployeeDirectory.Data.Contract
{
    public interface IManagerHandler
    {
        List<Manager> GetManagers();
        string? GetMangerNameById(int id);
    }
}