using CTC.Shared.Repository;
using Microsoft.EntityFrameworkCore;

namespace CTC.Infrastructure.Repository.CongestionTaxEntry;

public class CongestionTaxEntryQueryRepository : QueryRepository<Core.Entitys.CongestionTaxEntry>,
    ICongestionTaxEntryQueryRepository
{
    public CongestionTaxEntryQueryRepository(DbContext databaseContext) : base(databaseContext)
    {
    }

    public async Task<string> GetHighestTaxWithinWindowAsync(DateTime windowStart, DateTime windowEnd)
    {
        return await DbSet
            .Where(entry => entry.EntryTime >= windowStart && entry.EntryTime <= windowEnd)
            .MaxAsync(entry => entry.TaxAmount) ?? "0";
    }
}