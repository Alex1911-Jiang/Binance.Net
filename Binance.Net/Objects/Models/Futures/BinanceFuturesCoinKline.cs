﻿using Binance.Net.Converters;
using CryptoExchange.Net.Converters;

namespace Binance.Net.Objects.Models.Futures
{
    /// <summary>
    /// Candlestick information for symbol
    /// </summary>
    [JsonConverter(typeof(ArrayConverter<BinanceFuturesCoinKline>))]
    [SerializationModel]
    public record BinanceFuturesCoinKline : BinanceKlineBase
    {
        /// <inheritdoc/>
        [ArrayProperty(7)]
        public override decimal Volume { get; set; }
        /// <inheritdoc/>
        [ArrayProperty(5)]
        public override decimal QuoteVolume { get; set; }
        /// <inheritdoc/>
        [ArrayProperty(10)]
        public override decimal TakerBuyBaseVolume { get; set; }
        /// <inheritdoc/>
        [ArrayProperty(9)]
        public override decimal TakerBuyQuoteVolume { get; set; }
    }
}
