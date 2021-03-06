using System;
using Newtonsoft.Json;
using Xrpl.Client.Json.Converters;
using Xrpl.Client.Model;
using Xrpl.Client.Model.Transaction.Interfaces;
using Xrpl.Client.Responses.Transaction.Interfaces;

namespace Xrpl.Client.Responses.Transaction.TransactionTypes
{
    public class NFTokenAcceptOfferTransactionResponse : TransactionResponseCommon, INFTokenAcceptOfferTransaction
    {
        public string NFTokenID { get; set; }

    }
}
