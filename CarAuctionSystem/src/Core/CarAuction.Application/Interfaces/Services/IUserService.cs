namespace CarAuction.Application.Interfaces.Services;

using CarAuction.Domain.Entities;

public interface IUserService
{
    Task<User> RegisterUserAsync(string name, string email, decimal initialBalance);
    Task<User> GetUserByIdAsync(Guid userId);
    Task<User> GetUserByEmailAsync(string email);
    Task<IEnumerable<User>> GetAllUsersAsync();
    Task UpdateUserBalanceAsync(Guid userId, decimal amount);
}
