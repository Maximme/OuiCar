namespace OuiCar.Domain
{
    public class PoitiersParkingDTO : ParkingDTO
    {
        public int nhits { get; set; }
        public PoitiersParameters parameters { get; set; }
        public List<PoitiersRecord> records { get; set; }
    }
}
