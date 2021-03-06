using Xrpl.Client.Model.Transaction.Interfaces;

namespace Xrpl.Client.Model.Transaction.TransactionTypes
{
    public class SetFeeTransaction : TransactionCommon, ISetFeeTransaction
    {
        public SetFeeTransaction()
        {
            TransactionType = TransactionType.SetFee;
        }

        public string BaseFee { get; set; }

        public uint ReferenceFeeUnits { get; set; }

        public uint ReserveBase { get; set; }

        public uint ReserveIncrement { get; set; }

        public uint LedgerSequence { get; set; }
    }
}
