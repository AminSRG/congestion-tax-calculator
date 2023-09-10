using CTC.Infrastructure.Repository.CongestionTaxEntry;
using CTC.Infrastructure.Repository.CongestionTaxRate;
using CTC.Infrastructure.Repository.ExemptVehicleType;
using CTC.Infrastructure.Repository.TaxCalculationResult;
using CTC.Infrastructure.Repository.Vehicle;

namespace CTC.Infrastructure;

internal class QueryUnitOfWork : IQueryUnitOfWork
{
    private bool IsDisposed { get; set; }
    public ITaxCalculationResultQueryRepository TaxCalculationResults { get; }
    public ICongestionTaxEntryQueryRepository CongestionTaxEntries { get; }
    public IExemptVehicleTypeQueryRepository ExemptVehicleTypes { get; }
    public ICongestionTaxRateQueryRepository CongestionTaxRates { get; }
    public IVehicleQueryRepository Vehicles { get; }

    public QueryUnitOfWork(
        ITaxCalculationResultQueryRepository taxCalculationResultQueryRepository,
        ICongestionTaxEntryQueryRepository congestionTaxEntryQueryRepository,
        IExemptVehicleTypeQueryRepository exemptVehicleTypeQueryRepository,
        ICongestionTaxRateQueryRepository congestionTaxRateQueryRepository,
        IVehicleQueryRepository vehicleQueryRepository
    )
    {
        TaxCalculationResults = taxCalculationResultQueryRepository;
        CongestionTaxEntries = congestionTaxEntryQueryRepository;
        ExemptVehicleTypes = exemptVehicleTypeQueryRepository;
        CongestionTaxRates = congestionTaxRateQueryRepository;
        Vehicles = vehicleQueryRepository;
    }

    public void Dispose()
    {
        Dispose(true);

        GC.SuppressFinalize(this);
    }


    /// <summary>
    ///     https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-dispose
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
        if (IsDisposed) return;

        if (disposing) Dispose();
        
        IsDisposed = true;
    }

    ~QueryUnitOfWork()
    {
        Dispose(false);
    }
}