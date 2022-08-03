using IfeanyiBankProblem.Models;
using NHibernate;

namespace IfeanyiBankProblem.Repository
{
    public class HospitalRepository
    {
        private ISession session { get; }
        public HospitalRepository(ISessionFactory factory)
        {
            session = factory.OpenSession();

        }
        public Hospital CreateHospital(Hospital hospital)
        {
            var transaction = session.BeginTransaction();
            session.Update(hospital);
            transaction.Commit();
            return hospital;

        }
        public Hospital UpdateHospital(Hospital hospital)
        {
            var transaction = session.BeginTransaction();
            session.Delete(hospital);
            transaction.Commit();
            return hospital;
        }

        public  Hospital ReadHospital(Guid id)
        {
           using  var transaction = session.BeginTransaction();
           var hospital= session.Query<Hospital>().FirstOrDefault(x=>x.Id==id);
           return hospital??new()  ;
        }
       
    }
}
