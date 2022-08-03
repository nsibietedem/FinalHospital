namespace IfeanyiBankProblem.Models
{
    public class Appointment:BaseEntity
    {
        public Patient Patient { get; set; }
        public string Identity { get; set; }
        public Hospital Hospital { get; set; }
        public Doctor Doctor { get; set; }  
        public DateTime DateTime { get; set; }
        public Receptiontist Receptiontist { get; set; }
        public Accountant Accountant { get; set; }

        public string MedicalConditionReview { get; set; }

        public List<DrugAdministered> Drugs { get; set; }
        public List<BillBreakdown> Breakdown { get; set; }
        public List<PaidBill> PaidBill { get; set; }
       
        public DateTime AppointmentTime { get; set; }

        public double GetBalance(Appointment appointment)
        {
            var amountpaid = appointment.PaidBill.Sum(x => x.AmountPaid); 
            var totalAmount =appointment.Breakdown.Sum(x=>x.PaymentValue);
            return totalAmount - amountpaid;
        }

    }
}

