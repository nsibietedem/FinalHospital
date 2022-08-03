namespace IfeanyiBankProblem.Models
{
    public class Patient:BaseEntity
    {
        public string Name { get; set; }
        public List<PatientHospitalIdenitity> HospitalIdentity { get; set; }    

    }
}
