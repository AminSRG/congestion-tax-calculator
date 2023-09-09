using CTC.Shared.Repository;

namespace CTC.Infrastructure.Repository.Vehicle
{
    public class VehicleQueryRepository : QueryRepository<CTC.Core.Entitys.Vehicle>, IVehicleQueryRepository
    {
        public VehicleQueryRepository(CongestionTaxDbContext databaseContext) : base(databaseContext)
        {
        }
    }
}
