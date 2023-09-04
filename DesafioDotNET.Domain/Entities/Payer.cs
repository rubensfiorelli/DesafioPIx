namespace DesafioDotNET.Domain.Entities
{
    public sealed class Payer
    {

        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<TransactionPix> Transactions { get; set; }

    }
}