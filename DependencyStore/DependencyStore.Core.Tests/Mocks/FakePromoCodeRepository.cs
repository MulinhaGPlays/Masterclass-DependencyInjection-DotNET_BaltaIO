using DependencyStore.Core.Models;
using DependencyStore.Core.Repositories.Contracts;

namespace DependencyStore.Core.Tests.Mocks
{
    public class FakePromoCodeRepository : IPromoCodeRepository
    {
        public async Task<PromoCode?> GetAsync(string promoCode)
        {
            await Task.Delay(0);
            return new PromoCode
            {
                Code = "12345",
                Value = 10,
                ExpireDate = DateTime.Now.AddDays(30)
            };
        }
    }
}

