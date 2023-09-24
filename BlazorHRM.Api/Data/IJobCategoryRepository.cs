using BlazorHRM.Shared.Domain;

namespace BlazorHRM.Api.Data;
public interface IJobCategoryRepository
{
    IEnumerable<JobCategory> GetAllJobCategories();
    JobCategory GetJobCategoryById(int jobCategoryId);
}
