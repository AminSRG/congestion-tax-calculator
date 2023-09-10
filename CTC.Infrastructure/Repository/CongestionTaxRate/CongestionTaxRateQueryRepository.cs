using CTC.Shared.Repository;
using Microsoft.EntityFrameworkCore;

namespace CTC.Infrastructure.Repository.CongestionTaxRate
{
    public class CongestionTaxRateQueryRepository : QueryRepository<Core.Entitys.CongestionTaxRate>, ICongestionTaxRateQueryRepository
    {
        public CongestionTaxRateQueryRepository(CongestionTaxDbContext databaseContext) : base(databaseContext)
        {
        }

        public async Task<Core.Entitys.CongestionTaxRate> GetTaxRateByTimeIntervalAsync(string timeInterval)
        {
            return await this.DbSet.FirstAsync(current => current.TimeInterval == timeInterval);
        }
    }
}
