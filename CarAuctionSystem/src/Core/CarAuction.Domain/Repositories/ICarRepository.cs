namespace CarAuction.Domain.Repositories;

using CarAuction.Domain.Entities;

public interface ICarRepository
{
    Task<Car?> GetByIdAsync(Guid id);
    Task<IEnumerable<Car>> GetAllAsync();
    Task AddAsync(Car car);
    Task UpdateAsync(Car car);
    Task DeleteAsync(Guid id);
}
