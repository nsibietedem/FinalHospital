using IfeanyiBankProblem.Models;
using NHibernate;

namespace IfeanyiBankProblem.Repository
{
    public class DoctorsRepository
    {
        private ISession session { get; }
        public DoctorsRepository(ISessionFactory factory)
        {
            session = factory.OpenSession();

        }
        public Doctor CreateDoctor(Doctor doctor)
        {
            var transaction = session.BeginTransaction();
            session.Update(doctor);
            transaction.Commit();
            return doctor;

        }
        public Doctor UpdateDoctor(Doctor doctor)
        {
            var transaction = session.BeginTransaction();
            session.Delete(doctor);
            transaction.Commit();
            return doctor;
        }

        public Doctor ReadDoctor(Guid id)
        {
            using var transaction = session.BeginTransaction();
            var doctors = session.Query<Doctor>().FirstOrDefault(x => x.Id == id);
            return doctors ?? new();
        }
    } 
}

