using LayerDAL.Repository;
using LayerDAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCore7WithAdoNet.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeServices(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Employee>> ShowEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>();
            ListEmployees = await _repository.GetEmployees();
            return ListEmployees;
        }
    }
}
