using CTC.Shared.Repository;
using Microsoft.EntityFrameworkCore;

namespace CTC.Infrastructure.Repository.TaxCalculationResult;

public class TaxCalculationResultRepository : Repository<Core.Entitys.TaxCalculationResult>,
    ITaxCalculationResultRepository
{
    public TaxCalculationResultRepository(DbContext databaseContext) : base(databaseContext)
    {
    }
}