using CTC.Shared.Repository;
using Microsoft.EntityFrameworkCore;

namespace CTC.Infrastructure.Repository.CongestionTaxRate;

public class CongestionTaxRateQueryRepository : QueryRepository<Core.Entitys.CongestionTaxRate>,
    ICongestionTaxRateQueryRepository
{
    public CongestionTaxRateQueryRepository(DbContext databaseContext) : base(databaseContext)
    {
    }

    public async Task<Core.Entitys.CongestionTaxRate> GetTaxRateByTimeIntervalAsync(string timeInterval)
    {
        return await DbSet.FirstAsync(current => current.TimeInterval == timeInterval);
    }
}