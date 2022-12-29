using DependencyStore.Core.Models.Base;

namespace DependencyStore.Core.Models
{
    public class Product : EntityBase
    {
        public decimal Price { get; set; } = 0;
    }
}
