using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlazorApp.Shared
{
    public class IfpaRankingsResponse
    {
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; } = "";

        [JsonPropertyName("rankings")]
        public List<IfpaPlayerRanking> Rankings { get; set; } = new List<IfpaPlayerRanking>();   //= [];
    }

    public class IfpaPlayerRanking
    {
        [JsonPropertyName("player_id")]
        public string PlayerId { get; set; } = "";

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; } = "";

        [JsonPropertyName("last_name")]
        public string LastName { get; set; } = "";

        [JsonPropertyName("country_name")]
        public string Country { get; set; } = "";

        [JsonPropertyName("current_wppr_rank")]
        public string Rank { get; set; } = "";

        [JsonPropertyName("wppr_points")]
        public string WpprPoints { get; set; } = "";
    }
}
