using CTC.Shared.Repository;

namespace CTC.Infrastructure.Repository.ExemptVehicleType
{
    public class ExemptVehicleTypeQueryRepository : QueryRepository<CTC.Core.Entitys.ExemptVehicleType>, IExemptVehicleTypeQueryRepository
    {
        public ExemptVehicleTypeQueryRepository(CongestionTaxDbContext databaseContext) : base(databaseContext)
        {
        }
    }
}
