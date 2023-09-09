using CTC.Shared.Repository;

namespace CTC.Infrastructure.Repository.Vehicle
{
    public class VehicleQueryRepository : QueryRepository<Core.Entitys.Vehicle>, IVehicleQueryRepository
    {
        public VehicleQueryRepository(CongestionTaxDbContext databaseContext) : base(databaseContext)
        {
        }
    }
}
