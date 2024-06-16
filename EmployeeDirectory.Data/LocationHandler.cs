using EmployeeDirectory.Data.Contract;
using EmployeeDirectory.Data.Models;
using Microsoft.Data.SqlClient;

namespace EmployeeDirectory.Data
{
    public class LocationHandler : ILocationHandler
    {
        public List<Location> GetData()
        {
            using (var context = new SagarEmployeeDirectoryDbContext())
            {
                List<Location> locations = context.Locations.ToList();
                return locations;
            }
        }
        public string? GetLocationNameById(int id)
        {
            string? locationName;
            using (var context = new SagarEmployeeDirectoryDbContext())
            {
                locationName = context.Locations.SingleOrDefault(l => l.Id == id)!.Name;
                return locationName;
            }
        }
    }
}
