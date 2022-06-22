﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace RedPlusTest.Models
{
    /// <summary>
    /// Model Class: 
    /// </summary>
    public class Portfolio
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Portfolio>(this);
        }
    }
}
