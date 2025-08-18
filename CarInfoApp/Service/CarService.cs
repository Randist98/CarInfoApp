using CarInfoApp.Models;
using System.Net.Http.Json;

namespace CarInfoApp.Service
{
    public class CarService
    {
        private readonly HttpClient _httpClient;
        public CarService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Make>> GetAllMakes()
        {
            var response = await _httpClient.GetFromJsonAsync<ApiResponse<Make>>
                ("https://vpic.nhtsa.dot.gov/api/vehicles/getallmakes?format=json");

            return response?.Results ?? new List<Make>();
        }

        public async Task<List<VehicleType>> GetVehicleTypes(int makeId)
        {
            var response = await _httpClient.GetFromJsonAsync<ApiResponse<VehicleType>>
                ($"https://vpic.nhtsa.dot.gov/api/vehicles/GetVehicleTypesForMakeId/{makeId}?format=json");

            return response?.Results ?? new List<VehicleType>();
        }

        public async Task<List<CarModel>> GetModels(int makeId, int year)
        {
            var response = await _httpClient.GetFromJsonAsync<ApiResponse<CarModel>>
                ($"https://vpic.nhtsa.dot.gov/api/vehicles/GetModelsForMakeIdYear/makeId/{makeId}/modelyear/{year}?format=json");

            return response?.Results ?? new List<CarModel>();
        }

    }
}
