using CarSalesApi.Models;
using CarSalesApi.Repositories.Contracts;

namespace CarSalesApi.Repositories
{
    public class CarInfoRepository : ICarInfoRepository
    {
        public CarInfoRepository()
        {
            
        }

        public Task<CarInfo> AddCarInfoAsync(CarInfo carInfo)
        {
            throw new NotImplementedException();
        }

        public Task<CarInfo> DeleteCarInfoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CarInfo> GetCarInfoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CarInfo>> GetCarInfosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CarInfo> UpdateCarInfoAsync(CarInfo carInfo)
        {
            throw new NotImplementedException();
        }
    }

}


