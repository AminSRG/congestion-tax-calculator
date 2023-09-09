using CTC.Shared.Repository;

namespace CTC.Infrastructure.Repository.TaxCalculationResult
{
    public class TaxCalculationResultRepository : Repository<Core.Entitys.TaxCalculationResult>, ITaxCalculationResultRepository
    {
        public TaxCalculationResultRepository(CongestionTaxDbContext databaseContext) : base(databaseContext)
        {
        }
    }
}
