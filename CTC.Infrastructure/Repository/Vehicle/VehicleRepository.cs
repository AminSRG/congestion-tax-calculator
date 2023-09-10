using CTC.Shared.Repository;
using Microsoft.EntityFrameworkCore;

namespace CTC.Infrastructure.Repository.Vehicle;

public class VehicleRepository : Repository<Core.Entitys.Vehicle>, IVehicleRepository
{
    public VehicleRepository(DbContext databaseContext) : base(databaseContext)
    {
    }
}