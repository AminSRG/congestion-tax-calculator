using CTC.Infrastructure.Repository.CongestionTaxEntry;
using CTC.Infrastructure.Repository.CongestionTaxRate;
using CTC.Infrastructure.Repository.ExemptVehicleType;
using CTC.Infrastructure.Repository.TaxCalculationResult;
using CTC.Infrastructure.Repository.Vehicle;

namespace CTC.Infrastructure
{
    namespace CTC.Infrastructure
    {
        internal class UnitOfWork : IUnitOfWork
        {
            public bool IsDisposed { get; set; }
            public ITaxCalculationResultRepository TaxCalculationResults { get; }
            public ICongestionTaxEntryRepository CongestionTaxEntries { get; }
            public IExemptVehicleTypeRepository ExemptVehicleTypes { get; }
            public ICongestionTaxRateRepository CongestionTaxRates { get; }
            public IVehicleRepository Vehicles { get; }

            public UnitOfWork(
                ITaxCalculationResultRepository taxCalculationResultRepository,
                ICongestionTaxEntryRepository congestionTaxEntryRepository,
                IExemptVehicleTypeRepository exemptVehicleTypeRepository,
                ICongestionTaxRateRepository congestionTaxRateRepository,
                IVehicleRepository vehicleRepository
            )
            {
                TaxCalculationResults = taxCalculationResultRepository;
                CongestionTaxEntries = congestionTaxEntryRepository;
                ExemptVehicleTypes = exemptVehicleTypeRepository;
                CongestionTaxRates = congestionTaxRateRepository;
                Vehicles = vehicleRepository;
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (IsDisposed) return;

                if (disposing)
                {
                    // Dispose of resources here if needed
                }

                IsDisposed = true;
            }

            ~UnitOfWork()
            {
                Dispose(false);
            }
        }
    }
}