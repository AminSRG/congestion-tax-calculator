using CTC.Core.Entitys;

namespace CTC.Application
{
    public interface ICongestionTaxCalculator
    {
        Task<decimal> CalculateTax(CongestionTaxEntry entry);
    }
}