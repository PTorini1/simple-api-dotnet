namespace simple_api_dotnet.Models
{
    public interface IEmployee
    {
        void Add(Employee employee);
        List<Employee> Get();
    }
}
