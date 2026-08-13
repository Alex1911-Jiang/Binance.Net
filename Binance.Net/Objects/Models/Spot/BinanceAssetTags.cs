using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.Net.Objects.Models.Spot
{
    /// <summary>
    /// Asset tags
    /// </summary>
    public class BinanceAssetTags
    {
        /// <summary>
        /// ["<c>assetCode</c>"] Asset code
        /// </summary>
        [JsonPropertyName("assetCode")]
        public string AssetCode { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>assetName</c>"] Asset name
        /// </summary>
        [JsonPropertyName("assetName")]
        public string AssetName { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>trading</c>"] Trading
        /// </summary>
        [JsonPropertyName("trading")]
        public bool Trading { get; set; }
        /// <summary>
        /// ["<c>tags</c>"] Tags
        /// </summary>
        [JsonPropertyName("tags")]
        public string[] Tags { get; set; } = [];
    }
}
