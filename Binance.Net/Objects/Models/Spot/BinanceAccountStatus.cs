﻿namespace Binance.Net.Objects.Models.Spot
{
    /// <summary>
    /// Account status info
    /// </summary>
    [SerializationModel]
    public record BinanceAccountStatus
    {
        /// <summary>
        /// The result status
        /// </summary>
        [JsonPropertyName("data")]
        public string? Data { get; set; }
    }
}
