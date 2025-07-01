using dotnet_blazer_CRUD_app.Components.Domain;

namespace dotnet_blazer_CRUD_app.Components.Service
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDetailsDto>> GetAllEmployeesAsync();
        Task<EmployeeDetailsDto> GetEmployeeByIdAsync(Guid id);
        Task CreateEmployeeAsync(CreateEmployeeDto createEmployeeDto);
        Task UpdateEmployeeAsync(UpdateEmployeeDto updateEmployeeDto);
        Task DeleteEmployeeAsync(Guid id);
    }
}