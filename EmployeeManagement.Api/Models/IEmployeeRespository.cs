﻿using EmployeeManagement.Models;

namespace EmployeeManagement.Api.Models
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee> GetEmployeeByEmail(string employeeEmail);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int employeeId);
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
    }
}
