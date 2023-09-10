using CTC.Core.Entitys;
using CTC.Infrastructure;
using CTC.Shared.BaseEntitys.Abstracts;

namespace CTC.Application
{
    public class CongestionTaxCalculator : ICongestionTaxCalculator
    {
        private readonly IQueryUnitOfWork _queryUnitOfWork;

        public CongestionTaxCalculator(IQueryUnitOfWork unitOfWork)
        {
            _queryUnitOfWork = unitOfWork;
        }

        public async Task<decimal> CalculateTax(CongestionTaxEntry entry)
        {
            if (IsExempt(entry)) return 0;

            var timeInterval = GetTimeInterval(entry.EntryTime);
            var congestionTaxRate =
                await _queryUnitOfWork.CongestionTaxRates.GetTaxRateByTimeIntervalAsync(timeInterval);
            var taxRate = congestionTaxRate.Amount;

            var highestTaxWithinWindow = await GetHighestTaxWithinWindowAsync(entry.EntryTime);

            return Math.Min(long.Parse(taxRate), long.Parse(highestTaxWithinWindow));
        }

        private static bool IsExempt(CongestionTaxEntry entry)
        {
            var entryTime = entry.EntryTime;

            if (IsWeekend(entryTime) || IsJuly(entryTime)) return true;

            return entry.Vehicle.VehicleType != EVehicleType.Normal;
        }

        private static bool IsWeekend(DateTime entryTime) =>
            entryTime.DayOfWeek == DayOfWeek.Saturday || entryTime.DayOfWeek == DayOfWeek.Sunday;

        private static bool IsJuly(DateTime entryTime) => entryTime.Month == 7;

        private static string GetTimeInterval(DateTime entryTime)
        {
            var hour = entryTime.Hour;
            var minute = entryTime.Minute;

            return hour switch
            {
                >= 6 and < 7 when minute < 30 => "06:00–06:29",
                >= 6 and < 7 => "06:30–06:59",
                >= 7 and < 8 => "07:00–07:59",
                >= 8 and < 15 => "08:00–14:59",
                15 when minute < 30 => "15:00–15:29",
                >= 15 and < 17 => "15:30–16:59",
                >= 17 and < 18 => "17:00–17:59",
                >= 18 and < 19 when minute < 30 => "18:00–18:29",
                _ => "18:30–05:59"
            };
        }

        private async Task<string> GetHighestTaxWithinWindowAsync(DateTime entryTime)
        {
            var windowStart = entryTime.AddMinutes(-60);
            return await _queryUnitOfWork.CongestionTaxEntries.GetHighestTaxWithinWindowAsync(windowStart, entryTime);
        }
    }
}