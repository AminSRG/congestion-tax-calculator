﻿using CTC.Shared.IRepository;

namespace CTC.Infrastructure.Repository.CongestionTaxEntry;

public interface ICongestionTaxEntryQueryRepository : IQueryRepository<Core.Entitys.CongestionTaxEntry>
{
    Task<string> GetHighestTaxWithinWindowAsync(DateTime windowStart, DateTime windowEnd);
}