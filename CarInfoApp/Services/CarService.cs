using CarInfoApp.Models;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarInfoApp.Services
{
    public class CarService
    {
        private readonly HttpClient _httpClient;

        public CarService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<MakeModel>> GetAllMakes()
        {
            var response = await _httpClient.GetAsync("https://vpic.nhtsa.dot.gov/api/vehicles/getallmakes?format=json");
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(jsonString);
            var makes = doc.RootElement.GetProperty("Results");
            var result = new List<MakeModel>();

            foreach (var item in makes.EnumerateArray())
            {
                result.Add(new MakeModel
                {
                    Make_ID = item.GetProperty("Make_ID").GetInt32(),
                    Make_Name = item.GetProperty("Make_Name").GetString(),
                });
            }

            return result;
        }
    }
}
