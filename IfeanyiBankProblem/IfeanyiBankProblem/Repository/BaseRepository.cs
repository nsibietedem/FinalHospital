using IfeanyiBankProblem.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfeanyiBankProblem.Repository
{
    public class BaseRepository
    {
        public BaseRepository(ISessionFactory sessionFactory)
        {
         
        }

        public void Create(BaseEntity baseEntity)
        {
            var transaction = session.BeginTransaction();
            session.Save(baseEntity);
            transaction.Commit();

        }
        public void Create(Nurse nurse)
        {
            var transaction = session.BeginTransaction();
            session.Save(nurse);
            transaction.Commit();

        }
        public void Create(Receptiontist receptionist)
        {
            var transaction = session.BeginTransaction();
            session.Save(receptionist);
            transaction.Commit();

        } 
        public void Create(Accountant model)
        {
            var transaction = session.BeginTransaction();
            session.Save(model);
            transaction.Commit();

        }





        private   ISession session 
        {
            get
            {  
                    return SessionFactory.OpenSession();  
            } 
        }
        ISessionFactory SessionFactory { get; }
    }
 }
