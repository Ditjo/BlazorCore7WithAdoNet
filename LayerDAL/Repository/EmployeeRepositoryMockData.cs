using LayerDAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Numerics;

namespace LayerDAL.Repository
{
    public class EmployeeRepositoryMockData : IEmployeeRepository
    {
        public async Task<List<Employee>> GetEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>()
            {               new ()
                            {
                                Id = 1,
                                FirstName = "Palle",
                                LastName = "Westermann",
                                Email = "pwe@tec.dk",
                                Address = "Telegrafvej 666, Ballerup",
                                Phone = "23568978"
                            },
                            new()
                            {
                                Id = 2,
                                FirstName = "Palle the 2nd",
                                LastName = "Westermann Eternal 2nd",
                                Email = "pwe2@tec.dk",
                                Address = "Telegrafvej 2, Ballerup",
                                Phone = "22222222"
                            },
                            new ()
                            {
                                Id = 1,
                                FirstName = "Palle the 3rd. All Rise...",
                                LastName = "Westermann On and off no. 3",
                                Email = "pwe3@tec.dk",
                                Address = "Telegrafvej 3, Ballerup",
                                Phone = "33333333"
                            }
            };

            return ListEmployees;
        }
    }
}
