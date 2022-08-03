using IfeanyiBankProblem.Models;
using NHibernate;

namespace IfeanyiBankProblem.Repository
{
    public class AppointmentRepository
    {
        private ISession session { get; }
        public AppointmentRepository(ISessionFactory factory)
        {
            session = factory.OpenSession();

        }
        public Appointment CreateAppointment(Appointment appointment)
        {
            var transaction = session.BeginTransaction();
            session.Update(appointment);
            transaction.Commit();
            return appointment;

        }
        public Appointment UpdateAppointment(Appointment appointment)
        {
            var transaction = session.BeginTransaction();
            session.Delete(appointment);
            transaction.Commit();
            return appointment;
        }

        public Appointment ReadAppointment(Guid id)
        {
            using var transaction = session.BeginTransaction();
            var appointments = session.Query<Appointment>().FirstOrDefault(x => x.Id == id);
            return appointments ?? new();
        }
        public List<Patient> PatientsSeenByDoctor(DateTime date,Guid doctorId, Guid patientId)
        {
            using var transaction = session.BeginTransaction();
            var appointments = session.Query<Appointment>().Where(x =>x.AppointmentTime==date
            && x.Patient.Id == patientId && x.Doctor.Id == doctorId); 
            return appointments.Select(x => x.Patient).Distinct().ToList();

        }
        public List<Patient> GetAllPatientsById(Guid hospialid)
        {
            using var transaction = session.BeginTransaction();
            var patients = session.Query<Appointment>().Where(x => x.Hospital.Id == hospialid);
            return patients.Select(x => x.Patient).Distinct().ToList(); 
        }
    }
}

