using System.Collections.Generic;

namespace TimeManagement.Data
{
    public class EmployeeProvider : IEmployeeProvider
    {
        public IEnumerable<Employee> Get()
        {
            IEnumerable<Employee> employees = new List<Employee>();

            using (var connection = new SqlConnection())
            {

            }

            return employees;
        }
    }
}
