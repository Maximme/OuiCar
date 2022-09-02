
namespace OuiCar.Domain
{
    public class RochelleParkingDTO : ParkingDTO
    {
        public string help { get; set; }

        public bool success { get; set; }

        public RochelleResult result { get; set; }
    }
}
