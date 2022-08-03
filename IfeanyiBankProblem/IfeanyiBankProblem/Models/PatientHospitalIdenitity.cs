namespace IfeanyiBankProblem.Models
{
    public class PatientHospitalIdenitity : BaseEntity
    {
        public string Identity { get; set; }
        public Hospital Hospital { get; set; }  
    }
}
