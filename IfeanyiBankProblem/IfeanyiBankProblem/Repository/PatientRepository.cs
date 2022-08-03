using IfeanyiBankProblem.Models;
using NHibernate;

namespace IfeanyiBankProblem.Repository
{
    public class PatientRepository
    {
        private ISession session { get; }
        public PatientRepository(ISessionFactory factory)
        {
            session = factory.OpenSession();

        }
        public Patient CreatePatient(Patient patient)
        {
            var transaction = session.BeginTransaction();
            session.Update(patient);
            transaction.Commit();
            return patient;

        }
        public Patient UpdatePatient(Patient patient)
        {
            var transaction = session.BeginTransaction();
            session.Delete(patient);
            transaction.Commit();
            return patient;
        }

        public Patient ReadPatient(Guid id)
        {
            using var transaction = session.BeginTransaction();
            var patient = session.Query<Patient>().FirstOrDefault(x => x.Id == id);
            return patient ?? new();
        }
    }
   
}

