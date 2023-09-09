using CTC.Shared.Repository;

namespace CTC.Infrastructure.Repository.CongestionTaxEntry
{
    public class CongestionTaxEntryQueryRepository : QueryRepository<CTC.Core.Entitys.CongestionTaxEntry>, ICongestionTaxEntryQueryRepository
    {
        public CongestionTaxEntryQueryRepository(CongestionTaxDbContext databaseContext) : base(databaseContext)
        {
        }
    }
}
