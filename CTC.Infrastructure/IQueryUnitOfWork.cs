using CTC.Infrastructure.Repository.CongestionTaxEntry;
using CTC.Infrastructure.Repository.CongestionTaxRate;
using CTC.Infrastructure.Repository.ExemptVehicleType;
using CTC.Infrastructure.Repository.TaxCalculationResult;
using CTC.Infrastructure.Repository.Vehicle;

namespace CTC.Infrastructure;

public interface IQueryUnitOfWork : IDisposable
{
    // Define properties for your query repositories
    ITaxCalculationResultQueryRepository TaxCalculationResults { get; }
    ICongestionTaxEntryQueryRepository CongestionTaxEntries { get; }
    IExemptVehicleTypeQueryRepository ExemptVehicleTypes { get; }
    ICongestionTaxRateQueryRepository CongestionTaxRates { get; }
    IVehicleQueryRepository Vehicles { get; }
}