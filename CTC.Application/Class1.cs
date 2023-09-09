using CTC.Core.Entitys;
using CTC.Infrastructure;

namespace CTC.Application
{
    public class CongestionTaxCalculator
    {
        private readonly IQueryUnitOfWork _unitOfWork;

        public CongestionTaxCalculator(IQueryUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public decimal CalculateTax(CongestionTaxEntry entry)
        {
            if (IsWeekendOrHoliday(entry.EntryTime))
            {
                return 0;
            }

            if (IsJuly(entry.EntryTime))
            {
                return 0;
            }

            string timeInterval = GetTimeInterval(entry.EntryTime);

            decimal taxRate = _unitOfWork.CongestionTaxRates.GetTaxRateByTimeInterval(timeInterval);

            bool isExempt = _unitOfWork.ExemptVehicleTypes.IsVehicleExempt(entry.Vehicle.VehicleType);

            decimal taxAmount = isExempt ? 0 : taxRate;

            DateTime windowStart = entry.EntryTime.AddMinutes(-60);
            DateTime windowEnd = entry.EntryTime;
            decimal highestTaxWithinWindow = _unitOfWork.CongestionTaxEntries.GetHighestTaxWithinWindow(windowStart, windowEnd);

            if (taxAmount > highestTaxWithinWindow)
            {
                taxAmount = highestTaxWithinWindow;
            }

            return taxAmount;
        }

        private bool IsWeekendOrHoliday(DateTime entryTime)
        {
            // Check if the given date is a weekend (Saturday or Sunday)
            if (entryTime.DayOfWeek == DayOfWeek.Saturday || entryTime.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }

            // Implement logic to check if the given date is a public holiday
            // You may need to query a list of public holidays from your data store
            // Example:
            // if (_unitOfWork.HolidayRepository.IsPublicHoliday(entryTime))
            // {
            //     return true;
            // }

            // If it's neither a weekend nor a public holiday
            return false;
        }

        private bool IsJuly(DateTime entryTime)
        {
            // Check if the given date is in July (month number 7)
            return entryTime.Month == 7;
        }

        private string GetTimeInterval(DateTime entryTime)
        {
            if (entryTime.Hour >= 6 && entryTime.Hour < 6 && entryTime.Minute < 30)
            {
                return "06:00–06:29";
            }
            else if (entryTime.Hour >= 6 && entryTime.Hour < 7)
            {
                return "06:30–06:59";
            }
            else if (entryTime.Hour >= 7 && entryTime.Hour < 8)
            {
                return "07:00–07:59";
            }
            else if (entryTime.Hour >= 8 && entryTime.Hour < 14)
            {
                return "08:00–14:59";
            }
            else if (entryTime.Hour >= 15 && entryTime.Hour < 15 && entryTime.Minute < 30)
            {
                return "15:00–15:29";
            }
            else if (entryTime.Hour >= 15 && entryTime.Hour < 17)
            {
                return "15:30–16:59";
            }
            else if (entryTime.Hour >= 17 && entryTime.Hour < 18)
            {
                return "17:00–17:59";
            }
            else if (entryTime.Hour >= 18 && entryTime.Hour < 18 && entryTime.Minute < 30)
            {
                return "18:00–18:29";
            }
            else
            {
                return "18:30–05:59"; // Covers the night hours until 05:59
            }
        }

    }
}