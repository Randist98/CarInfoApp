using System.Text.Json.Serialization;

namespace CarInfoApp.Models
{
    public class Make
    {
        [JsonPropertyName("Make_ID")]
        public int MakeId { get; set; }

        [JsonPropertyName("Make_Name")]
        public string MakeName { get; set; }
    }
}
