using LayerDAL.Entities;

namespace BlazorCore7WithAdoNet.Services
{
    public interface IEmployeeServices
    {
        Task<List<Employee>> ShowEmployees();
    }
}