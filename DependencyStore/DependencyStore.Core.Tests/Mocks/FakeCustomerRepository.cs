using DependencyStore.Core.Models;
using DependencyStore.Core.Repositories.Contracts;

namespace DependencyStore.Core.Tests.Mocks
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public async Task<Customer?> GetByEmailAsync(string email)
        {
            await Task.Delay(0);
            return new Customer
            {
                Email = "email@mail.com",
                Id = "CS12345",
                Name = "John Sullivan"
            };
        }
    }
}

