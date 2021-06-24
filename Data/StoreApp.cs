using System;
using Newtonsoft.Json;

 public class StoreApp
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }

    }