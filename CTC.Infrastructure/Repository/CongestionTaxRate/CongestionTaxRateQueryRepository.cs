using CTC.Shared.Repository;

namespace CTC.Infrastructure.Repository.CongestionTaxRate
{
    public class CongestionTaxRateQueryRepository : QueryRepository<CTC.Core.Entitys.CongestionTaxRate>, ICongestionTaxRateQueryRepository
    {
        public CongestionTaxRateQueryRepository(CongestionTaxDbContext databaseContext) : base(databaseContext)
        {
        }
    }
}
