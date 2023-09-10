using CTC.Shared.Repository;
using Microsoft.EntityFrameworkCore;

namespace CTC.Infrastructure.Repository.ExemptVehicleType;

public class ExemptVehicleTypeQueryRepository : QueryRepository<Core.Entitys.ExemptVehicleType>,
    IExemptVehicleTypeQueryRepository
{
    public ExemptVehicleTypeQueryRepository(DbContext databaseContext) : base(databaseContext)
    {
    }
}