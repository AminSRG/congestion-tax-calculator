using CTC.Shared.Repository;

namespace CTC.Infrastructure.Repository.CongestionTaxEntry
{
    public class CongestionTaxEntryRepository : Repository<Core.Entitys.CongestionTaxEntry>, ICongestionTaxEntryRepository
    {
        public CongestionTaxEntryRepository(CongestionTaxDbContext databaseContext) : base(databaseContext)
        {
        }
    }
}
