namespace CarInfoApp.Models
{
    public class ApiResponse<T>
    {
        public List<T> Results { get; set; }
    }
}