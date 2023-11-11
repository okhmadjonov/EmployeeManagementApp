namespace EmployeesManagement.Web.Repositories
{
    public interface ICsvRepository
    {
        Task<int> LoadFromCSVAsync(StreamReader stream);
    }
}
