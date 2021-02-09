namespace WebApi.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool Visible { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
