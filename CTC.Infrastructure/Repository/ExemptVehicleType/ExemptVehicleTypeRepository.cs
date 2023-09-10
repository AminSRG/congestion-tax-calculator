using CTC.Shared.Repository;
using Microsoft.EntityFrameworkCore;

namespace CTC.Infrastructure.Repository.ExemptVehicleType;

public class ExemptVehicleTypeRepository : Repository<Core.Entitys.ExemptVehicleType>, IExemptVehicleTypeRepository
{
    public ExemptVehicleTypeRepository(DbContext databaseContext) : base(databaseContext)
    {
    }
}