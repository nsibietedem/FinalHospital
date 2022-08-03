namespace IfeanyiBankProblem.Models
{
    public class Hospital:BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Doctor> Doctors { get; set; } = new();

        public List<Nurse> Nurses { get; set; } = new();
        public Pharmacist Pharmacist { get; set; }=new();
        public Receptiontist Receptiontist { get; set; }= new();

    }    }

