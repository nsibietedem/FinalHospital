namespace IfeanyiBankProblem.Models
{
    public class Nurse:BaseEntity
    {
        public string Name { get; set; }
        public Hospital Hospital { get; set; }
    }
}
