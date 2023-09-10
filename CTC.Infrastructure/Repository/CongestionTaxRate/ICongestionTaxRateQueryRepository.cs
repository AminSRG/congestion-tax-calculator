using CTC.Shared.IRepository;

namespace CTC.Infrastructure.Repository.CongestionTaxRate
{

    public interface ICongestionTaxRateQueryRepository : IQueryRepository<Core.Entitys.CongestionTaxRate>
    {
        Task<Core.Entitys.CongestionTaxRate> GetTaxRateByTimeIntervalAsync(string timeInterval);
    }
}
