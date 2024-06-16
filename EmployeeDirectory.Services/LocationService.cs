using AutoMapper;
using EmployeeDirectory.Data;
using EmployeeDirectory.Data.Contract;
using EmployeeDirectory.Models;
using EmployeeDirectory.Services.Contract;

namespace EmployeeDirectory.Services
{
    public class LocationService : ILocationService
    {
        ILocationHandler _locationHandler;
        IMapper _mapper;
        public LocationService(ILocationHandler locationHandler,IMapper mapper)
        {
            this._locationHandler = locationHandler;
            this._mapper = mapper;
        }
        public List<Location> GetLocations()
        {
            var locations = _mapper.Map<List<Data.Models.Location>, List<Models.Location>>(_locationHandler.GetData());
            return locations;

        }
        public string? GetLocationName(int id)
        {
            return _locationHandler.GetLocationNameById(id);
        }
    }
}
