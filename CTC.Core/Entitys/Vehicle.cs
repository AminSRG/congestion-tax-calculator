using CTC.Core.Base.Interface;
using CTC.Core.Base.Model;

namespace CTC.Core.Entitys
{
    public class Vehicle : BaseModel, IVehicle
    {
        public EVehicleType VehicleType { get; set; }
        public string LicensePlate { get; set; }

    }
}