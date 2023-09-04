namespace DesafioDotNET.Domain.Entities
{
    public sealed class TransactionPix
    {

        public Guid Id { get; set; }
        public DateTimeOffset DateTrans { get; set; }
        public Guid PayerId { get; set; }
        public Payer? Payer { get; set; }
        public Guid ReceiverId { get; set; }
        public Receiver? Receiver { get; set; }

    }
}
