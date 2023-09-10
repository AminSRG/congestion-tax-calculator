using CTC.Shared.Repository;
using Microsoft.EntityFrameworkCore;

namespace CTC.Infrastructure.Repository.CongestionTaxRate;

public class CongestionTaxRateRepository : Repository<Core.Entitys.CongestionTaxRate>, ICongestionTaxRateRepository
{
    public CongestionTaxRateRepository(DbContext databaseContext) : base(databaseContext)
    {
    }
}