using DesafioDotNET.Domain.Enums;

namespace DesafioDotNET.Domain.Entities
{
    public sealed class KeyPix
    {
        public Guid Id { get; set; }
        public EKeyType KeyType { get; set; }
        public string Description { get; set; }
    }
}
