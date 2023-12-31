using BlazorHRM.Shared.Domain;

namespace BlazorHRM.App.Services;

public interface IEmployeeDataService
{
    Task<IEnumerable<Employee>> GetAllEmployees(bool refreshrequired);
    Task<Employee> GetEmployeeDetails(int employeeId);
    Task<Employee> AddEmployee(Employee employee);
    Task UpdateEmployee(Employee employee);
    Task DeleteEmployee(int employeeId);
}