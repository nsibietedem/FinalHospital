namespace IfeanyiBankProblem.Models
{
    public class Doctor:BaseEntity
    {
        public string Name { get; set; }
        public Hospital Hospital { get; set; }  


    }
}
