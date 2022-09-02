namespace OuiCar.Domain
{
    public class PoitiersRecord
    {
        public string datasetid { get; set; }
        public string recordid { get; set; }
        public PoitiersFields fields { get; set; }
        public PoitiersGeometry geometry { get; set; }
        public string record_timestamp { get; set; }
    }
}
