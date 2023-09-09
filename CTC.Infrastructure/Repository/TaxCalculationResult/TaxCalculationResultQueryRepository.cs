using CTC.Shared.Repository;

namespace CTC.Infrastructure.Repository.TaxCalculationResult
{
    public class TaxCalculationResultQueryRepository : QueryRepository<Core.Entitys.TaxCalculationResult>, ITaxCalculationResultQueryRepository
    {
        public TaxCalculationResultQueryRepository(CongestionTaxDbContext databaseContext) : base(databaseContext)
        {
        }
    }
}
