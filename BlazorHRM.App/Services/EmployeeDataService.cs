using System.Text.Json;
using Blazored.LocalStorage;
using BlazorHRM.App.Helpers;
using BlazorHRM.Shared.Domain;

namespace BlazorHRM.App.Services;

public class EmployeeDataService:IEmployeeDataService
{
    private readonly HttpClient _httpClient;
    private readonly ILocalStorageService _localStorageService;

    public EmployeeDataService(HttpClient httpClient, ILocalStorageService localStorageService)
    {
        _httpClient = httpClient;
        _localStorageService = localStorageService;
    }

    public async Task<IEnumerable<Employee>> GetAllEmployees(bool refreshRequired = false)
    {
        //better to this with app state store, this just for demo
        if (refreshRequired)
        {
            bool employeeExpirationExists = await _localStorageService.ContainKeyAsync(LocalStorageConstants.EmployeeListExpirationKey);
            if (employeeExpirationExists)
            {
                DateTime employeeListExpiration = await _localStorageService.GetItemAsync<DateTime>(LocalStorageConstants.EmployeeListExpirationKey);
                if (employeeListExpiration > DateTime.Now)//get from local storage
                {
                    if (await _localStorageService.ContainKeyAsync(LocalStorageConstants.EmployeeListKey))
                    {
                        return await _localStorageService.GetItemAsync<List<Employee>>(LocalStorageConstants.EmployeeListKey);
                    }
                }
            }
        }
        //otherwise refresh the list locally from the API and set expiration to 1 minute in future
        var list = await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>
            (await _httpClient.GetStreamAsync($"api/employee"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

        await _localStorageService.SetItemAsync(LocalStorageConstants.EmployeeListKey, list);
        await _localStorageService.SetItemAsync(LocalStorageConstants.EmployeeListExpirationKey, DateTime.Now.AddMinutes(1));

        return list;
        // return await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>
        //     (await _httpClient.GetStreamAsync($"api/employee"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
    }

    public async Task<Employee> GetEmployeeDetails(int employeeId)
    {
        return await JsonSerializer.DeserializeAsync<Employee>
            (await _httpClient.GetStreamAsync($"api/employee/{employeeId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
    }

    public Task<Employee> AddEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Task UpdateEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Task DeleteEmployee(int employeeId)
    {
        throw new NotImplementedException();
    }
}