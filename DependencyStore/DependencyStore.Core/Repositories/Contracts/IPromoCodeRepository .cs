using DependencyStore.Core.Models;

namespace DependencyStore.Core.Repositories.Contracts
{
    public interface IPromoCodeRepository
    {
        Task<PromoCode?> GetAsync(string promoCode);
    }
}
