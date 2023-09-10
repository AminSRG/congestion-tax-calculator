using CTC.Shared.Repository;
using Microsoft.EntityFrameworkCore;

namespace CTC.Infrastructure.Repository.TaxCalculationResult;

public class TaxCalculationResultQueryRepository : QueryRepository<Core.Entitys.TaxCalculationResult>,
    ITaxCalculationResultQueryRepository
{
    public TaxCalculationResultQueryRepository(DbContext databaseContext) : base(databaseContext)
    {
    }
}