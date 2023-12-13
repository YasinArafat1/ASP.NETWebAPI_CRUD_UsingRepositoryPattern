using PipilikaAPI.Models.Domain;

namespace PipilikaAPI.Repositories
{
    public interface IEmployeeRepositories
    {
        Task<Employee>CreateAsync(Employee employee);
        Task<List<Employee>> GetAllAsync(string? filterOn=null,string? filterQuery=null);


        Task<Employee?> GetByIdAsync(Guid id);

       Task<Employee?> UpdateAsync(Guid id, Employee employee);


        Task<Employee?> DeleteAsync(Guid id);


    }
}
