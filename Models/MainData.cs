using Newtonsoft.Json;

namespace WebApplication1.Models
{
    public class MainData
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }
    }
}
