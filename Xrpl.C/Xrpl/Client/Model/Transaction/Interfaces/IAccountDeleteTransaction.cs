using System.Collections.Generic;

namespace Xrpl.Client.Model.Transaction.Interfaces
{
    public interface IAccountDeleteTransaction : ITransactionCommon
    {
        Currency DeliverMin { get; set; }
        string Destination { get; set; }
        uint? DestinationTag { get; set; }
        //new AccountDeleteFlags? Flags { get; set; }
        string InvoiceId { get; set; }
        List<List<Path>> Paths { get; set; }
        Currency SendMax { get; set; }
    }
}
