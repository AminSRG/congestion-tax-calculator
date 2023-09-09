using CTC.Shared.Repository;

namespace CTC.Infrastructure.Repository.CongestionTaxEntry
{
    public class CongestionTaxEntryQueryRepository : QueryRepository<Core.Entitys.CongestionTaxEntry>, ICongestionTaxEntryQueryRepository
    {
        public CongestionTaxEntryQueryRepository(CongestionTaxDbContext databaseContext) : base(databaseContext)
        {
        }
    }
}
