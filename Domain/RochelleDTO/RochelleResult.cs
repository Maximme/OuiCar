namespace OuiCar.Domain
{
    public class RochelleResult
    {
        public bool include_total { get; set; }
        public string resource_id { get; set; }
        public List<RochelleField> fields { get; set; }
        public string records_format { get; set; }
        public List<RochelleRecord> records { get; set; }
        public RochelleLinks _links { get; set; }
        public int total { get; set; }
    }
}
