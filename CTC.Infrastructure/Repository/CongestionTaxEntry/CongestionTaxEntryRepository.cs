using CTC.Shared.Repository;
using Microsoft.EntityFrameworkCore;

namespace CTC.Infrastructure.Repository.CongestionTaxEntry;

public class CongestionTaxEntryRepository : Repository<Core.Entitys.CongestionTaxEntry>, ICongestionTaxEntryRepository
{
    public CongestionTaxEntryRepository(DbContext databaseContext) : base(databaseContext)
    {
    }
}