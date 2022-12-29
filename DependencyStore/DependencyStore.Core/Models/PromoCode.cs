using DependencyStore.Core.Models.Base;

namespace DependencyStore.Core.Models
{
    public class PromoCode : ArgumentBase
    {
        public DateTime ExpireDate { get; set; } = DateTime.Now;
        public decimal Value { get; set; } = 0;
    }
}
