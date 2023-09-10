using CTC.Core.Entitys;
using CTC.Infrastructure;
using CTC.Shared.BaseEntitys.Abstracts;

namespace CTC.Application
{
    public class CongestionTaxCalculator
    {
        private readonly IQueryUnitOfWork _queryUnitOfWork;

        public CongestionTaxCalculator(IQueryUnitOfWork unitOfWork)
        {
            _queryUnitOfWork = unitOfWork;
        }

        public async Task<decimal> CalculateTax(CongestionTaxEntry entry)
        {
            if (IsExempt(entry)) return 0;

            string timeInterval = GetTimeInterval(entry.EntryTime);
            var congestionTaxRate = await _queryUnitOfWork.CongestionTaxRates.GetTaxRateByTimeIntervalAsync(timeInterval);
            var taxRate = congestionTaxRate.Amount;

            string highestTaxWithinWindow = await GetHighestTaxWithinWindowAsync(entry.EntryTime);

            return Math.Min(long.Parse(taxRate), long.Parse(highestTaxWithinWindow));
        }
        
        private static bool IsExempt(CongestionTaxEntry entry)
        {
            DateTime entryTime = entry.EntryTime;

            if (IsWeekend(entryTime) || IsJuly(entryTime)) return true;

            if (entry.Vehicle.VehicleType == EVehicleType.Normal) return false;
            return true;
        }

        private static bool IsWeekend(DateTime entryTime) => entryTime.DayOfWeek == DayOfWeek.Saturday || entryTime.DayOfWeek == DayOfWeek.Sunday;

        private static bool IsJuly(DateTime entryTime) => entryTime.Month == 7;

        private static string GetTimeInterval(DateTime entryTime)
        {
            int hour = entryTime.Hour;
            int minute = entryTime.Minute;

            if (hour >= 6 && hour < 7 && minute < 30) return "06:00–06:29";
            else if (hour >= 6 && hour < 7) return "06:30–06:59";
            else if (hour >= 7 && hour < 8) return "07:00–07:59";
            else if (hour >= 8 && hour < 15) return "08:00–14:59";
            else if (hour == 15 && minute < 30) return "15:00–15:29";
            else if (hour >= 15 && hour < 17) return "15:30–16:59";
            else if (hour >= 17 && hour < 18) return "17:00–17:59";
            else if (hour >= 18 && hour < 19 && minute < 30) return "18:00–18:29";
            else return "18:30–05:59";
        }

        private async Task<string> GetHighestTaxWithinWindowAsync(DateTime entryTime)
        {
            var windowStart = entryTime.AddMinutes(-60);
            var windowEnd = entryTime;
            return await _queryUnitOfWork.CongestionTaxEntries.GetHighestTaxWithinWindowAsync(windowStart, windowEnd);
        }
    }
}
