namespace CarAuction.Application.Services;

using CarAuction.Application.Interfaces.Services;
using CarAuction.Domain.Entities;
using CarAuction.Domain.Exceptions;
using CarAuction.Domain.Repositories;

/// <summary>
/// User service implementation
/// </summary>
public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;

    public UserService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<User> RegisterUserAsync(string name, string email, decimal initialBalance)
    {
        var existingUser = await _unitOfWork.Users.GetByEmailAsync(email);
        if (existingUser != null)
            throw new InvalidOperationException($"User with email '{email}' already exists.");

        var user = new User(name, email, initialBalance);
        await _unitOfWork.Users.AddAsync(user);
        await _unitOfWork.SaveChangesAsync();
        return user;
    }

    public async Task<User> GetUserByIdAsync(Guid userId)
    {
        var user = await _unitOfWork.Users.GetByIdAsync(userId);
        if (user == null)
            throw new UserNotFoundException(userId);
        return user;
    }

    public async Task<User> GetUserByEmailAsync(string email)
    {
        var user = await _unitOfWork.Users.GetByEmailAsync(email);
        if (user == null)
            throw new InvalidOperationException($"User with email '{email}' not found.");
        return user;
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return await _unitOfWork.Users.GetAllAsync();
    }

    public async Task UpdateUserBalanceAsync(Guid userId, decimal amount)
    {
        var user = await GetUserByIdAsync(userId);
        user.Balance += amount;
        user.LastModifiedDate = DateTime.UtcNow;
        await _unitOfWork.Users.UpdateAsync(user);
        await _unitOfWork.SaveChangesAsync();
    }
}
