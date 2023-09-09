using CTC.Infrastructure.Repository.CongestionTaxEntry;
using CTC.Infrastructure.Repository.CongestionTaxRate;
using CTC.Infrastructure.Repository.ExemptVehicleType;
using CTC.Infrastructure.Repository.TaxCalculationResult;
using CTC.Infrastructure.Repository.Vehicle;

namespace CTC.Infrastructure
{

    namespace CTC.Infrastructure
    {
        public interface IUnitOfWork : IDisposable
        {
            // Define properties for your repositories
            ITaxCalculationResultRepository TaxCalculationResults { get; }
            ICongestionTaxEntryRepository CongestionTaxEntries { get; }
            IExemptVehicleTypeRepository ExemptVehicleTypes { get; }
            ICongestionTaxRateRepository CongestionTaxRates { get; }
            IVehicleRepository Vehicles { get; }
        }
    }

}
