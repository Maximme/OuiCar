namespace OuiCar.Domain
{
    public class PoitiersFields
    {
        public double taux_doccupation { get; set; }
        public float capacite { get; set; }
        public float places_restantes { get; set; }
        public string nom { get; set; }
        public string id { get; set; }
        public List<double> geo_point_2d { get; set; }
        public string derniere_mise_a_jour_base { get; set; }
    }
}
