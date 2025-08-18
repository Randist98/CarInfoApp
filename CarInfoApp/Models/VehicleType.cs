using System.Text.Json.Serialization;

namespace CarInfoApp.Models
{
    public class VehicleType
    {
        [JsonPropertyName("VehicleTypeId")]
        public int VehicleTypeId { get; set; }

        [JsonPropertyName("VehicleTypeName")]
        public string VehicleTypeName { get; set; }
    }
}
