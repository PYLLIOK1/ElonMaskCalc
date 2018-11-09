using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;

namespace EM.Calc.DB
{
    public class NHUserRepository : IEntityRepository<User>
    {
        public User Create(User User)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            using (var transaction = session.BeginTransaction())
            {
                var entity = session.Get<User>(id);
                session.Delete(entity);
                transaction.Commit();
            }
            NHibernateHelper.CloseSession();
        }

        public IEnumerable<User> GetAll()
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            var list = session.CreateCriteria<User>()
                .List<User>();

            NHibernateHelper.CloseSession();

            return list;
        }

        public User Load(long id)
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            var entity = session.Load<User>(id);

            NHibernateHelper.CloseSession();

            return entity;
        }

        public void Save(User User)
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            using (var transaction = session.BeginTransaction())
            {
                session.Save(User);
                transaction.Commit();
            }
            NHibernateHelper.CloseSession();
        }
    }
}