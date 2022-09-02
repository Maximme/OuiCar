namespace OuiCar.Domain
{
    public class RochelleRecord
    {
        public int _id { get; set; }
        public string id { get; set; }
        public string nom { get; set; }
        public double ylat { get; set; }
        public double xlong { get; set; }
        public double coord_x { get; set; }
        public double coord_y { get; set; }
        public string date_comptage { get; set; }
        public int? nb_places { get; set; }
        public int? nb_places_disponibles { get; set; }
        public int? nb_pr { get; set; }
        public int? nb_pr_dispo { get; set; }
        public int? nb_pmr { get; set; }
        public int? nb_pmr_dispo { get; set; }
        public int? nb_voitures_electriques { get; set; }
        public int? nb_voitures_electriques_dispo { get; set; }
        public int? nb_velo { get; set; }
        public int? nb_velo_dispo { get; set; }
        public int? nb_2r_el { get; set; }
        public int? nb_2r_el_dispo { get; set; }
        public int? nb_autopartage { get; set; }
        public int? nb_autopartage_dispo { get; set; }
        public int? nb_2_rm { get; set; }
        public int? nb_2_rm_dispo { get; set; }

    }
}
