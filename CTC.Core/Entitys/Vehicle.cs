using CTC.Core.Base.Interface;
using CTC.Core.Base.Model;

namespace CTC.Core.Entitys
{

    // Vehicle class representing information about a vehicle
    public class Vehicle : BaseModel, IVehicle
    {
        public EVehicleType VehicleType { get; set; }
        public string LicensePlate { get; set; }

    }
}