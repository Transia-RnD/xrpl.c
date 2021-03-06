using System;
using Newtonsoft.Json;
using Xrpl.Client.Json.Converters;
using Xrpl.Client.Responses.Transaction.Interfaces;

namespace Xrpl.Client.Responses.Transaction
{
    public class BaseTransactionResponse : IBaseTransactionResponse
    {
        [JsonConverter(typeof(RippleDateTimeConverter))]
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("inLedger")]
        public uint? InLedger { get; set; }

        [JsonProperty("ledger_index")]
        public uint? LedgerIndex { get; set; }

        [JsonProperty("validated")]
        public bool? Validated { get; set; }
    }
}
