namespace CarAuction.Infrastructure.Repositories;

using CarAuction.Domain.Entities;
using CarAuction.Domain.Repositories;

/// <summary>
/// User repository implementation - TODO: Implement methods
/// </summary>
public class UserRepository : IUserRepository
{
    public async Task<User?> GetByIdAsync(Guid id) => throw new NotImplementedException();
    public async Task<User?> GetByEmailAsync(string email) => throw new NotImplementedException();
    public async Task<IEnumerable<User>> GetAllAsync() => throw new NotImplementedException();
    public async Task AddAsync(User user) => throw new NotImplementedException();
    public async Task UpdateAsync(User user) => throw new NotImplementedException();
    public async Task DeleteAsync(Guid id) => throw new NotImplementedException();
}
