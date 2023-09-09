using CTC.Shared.Repository;

namespace CTC.Infrastructure.Repository.ExemptVehicleType
{
    public class ExemptVehicleTypeRepository : Repository<CTC.Core.Entitys.ExemptVehicleType>, IExemptVehicleTypeRepository
    {
        public ExemptVehicleTypeRepository(CongestionTaxDbContext databaseContext) : base(databaseContext)
        {
        }
    }
}
