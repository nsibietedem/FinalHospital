namespace IfeanyiBankProblem.Models
{
    public class DrugDosage:BaseEntity
    {
        public Drug Drug { get; set; }
        public int Dosage { get; set; }
    }
}
