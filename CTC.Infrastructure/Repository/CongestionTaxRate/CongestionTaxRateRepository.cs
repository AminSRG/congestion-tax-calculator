using CTC.Shared.Repository;

namespace CTC.Infrastructure.Repository.CongestionTaxRate
{
    public class CongestionTaxRateRepository : Repository<CTC.Core.Entitys.CongestionTaxRate>, ICongestionTaxRateRepository
    {
        public CongestionTaxRateRepository(CongestionTaxDbContext databaseContext) : base(databaseContext)
        {
        }
    }
}
