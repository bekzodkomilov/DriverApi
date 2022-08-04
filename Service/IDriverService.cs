using DriverLibrary.Entities;

namespace DriverLibrary.Service;

public interface IDriverService
{
    Task<Driver> GetDriverByIdAsync(Guid id);
    Task<List<Driver>> GetAllDriverAsync();
    Task<(bool IsSuccess, Exception e)> InsertDriverAsync(Driver driver);
    Task<(bool IsSuccess, Exception e)> UpdateDriverAsync(Driver driver);
    Task<(bool IsSuccess, Exception e)> DeleteDriverIdAsync(Guid id);
}