using System.Text.Json.Serialization;

namespace CarInfoApp.Models
{
    public class CarModel
    {
        [JsonPropertyName("Model_ID")]
        public int ModelId { get; set; }

        [JsonPropertyName("Model_Name")]
        public string ModelName { get; set; }
    }
}
