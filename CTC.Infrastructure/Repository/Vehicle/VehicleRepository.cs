using CTC.Shared.Repository;

namespace CTC.Infrastructure.Repository.Vehicle
{
    public class VehicleRepository : Repository<CTC.Core.Entitys.Vehicle>, IVehicleRepository
    {
        public VehicleRepository(CongestionTaxDbContext databaseContext) : base(databaseContext)
        {
        }
    }
}
