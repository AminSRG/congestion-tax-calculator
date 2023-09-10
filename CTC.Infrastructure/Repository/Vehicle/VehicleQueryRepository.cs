using CTC.Shared.Repository;
using Microsoft.EntityFrameworkCore;

namespace CTC.Infrastructure.Repository.Vehicle;

public class VehicleQueryRepository : QueryRepository<Core.Entitys.Vehicle>, IVehicleQueryRepository
{
    public VehicleQueryRepository(DbContext databaseContext) : base(databaseContext)
    {
    }
}