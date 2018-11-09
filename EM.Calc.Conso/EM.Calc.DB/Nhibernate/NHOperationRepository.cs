using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;

namespace EM.Calc.DB
{
    public class NHOperationRepository : IEntityRepository<Operation>
    {
        public Operation Create(Operation Operation)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            using (var transaction = session.BeginTransaction())
            {
                var entity = session.Get<Operation>(id);
                session.Delete(entity);
                transaction.Commit();
            }
            NHibernateHelper.CloseSession();
        }

        public IEnumerable<Operation> GetAll()
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            var list = session.CreateCriteria<Operation>()
                .List<Operation>();

            NHibernateHelper.CloseSession();

            return list;
        }

        public Operation Load(long id)
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            var entity = session.Load<Operation>(id);

            NHibernateHelper.CloseSession();

            return entity;
        }

        public void Save(Operation Operation)
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            using (var transaction = session.BeginTransaction())
            {
                session.Save(Operation);
                transaction.Commit();
            }
            NHibernateHelper.CloseSession();
        }
    }
}