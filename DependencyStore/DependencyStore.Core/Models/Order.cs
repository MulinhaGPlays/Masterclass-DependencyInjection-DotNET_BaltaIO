using DependencyStore.Core.Models.Base;

namespace DependencyStore.Core.Models
{
    public class Order : ArgumentBase
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal DeliveryFee { get; set; } = 0;
        public decimal Discount { get; set; } = 0;
        public int[] Products { get; set; } = Array.Empty<int>();
        public decimal SubTotal { get; set; } = 0;
        public decimal Total { get; set; } = 0;
    }
}
