using DependencyStore.Core.Models.Base;

namespace DependencyStore.Core.Models
{
    public class Customer : EntityBase
    {
        public string Email { get; set; } = String.Empty;
    }
}
