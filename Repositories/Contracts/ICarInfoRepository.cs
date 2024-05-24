using CarSalesApi.Models;

namespace CarSalesApi.Repositories.Contracts
{
    public interface ICarInfoRepository
    {
        Task<IEnumerable<CarInfo>> GetCarInfosAsync();
        Task<CarInfo> GetCarInfoAsync(int id);
        Task<CarInfo> AddCarInfoAsync(CarInfo carInfo);
        Task<CarInfo> UpdateCarInfoAsync(CarInfo carInfo);
        Task<CarInfo> DeleteCarInfoAsync(int id);
    }
}