using System;
using Newtonsoft.Json;

 public class StoreApp
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }

    [JsonProperty("rating")]
    public double Rating { get; set; }

    [JsonProperty("people")]
    public int People { get; set; }

    [JsonProperty("category")]
    public string Category { get; set; }

    [JsonProperty("date")]
    public string Date { get; set; }
    [JsonProperty("price")]
    public string Price { get; set; }

}