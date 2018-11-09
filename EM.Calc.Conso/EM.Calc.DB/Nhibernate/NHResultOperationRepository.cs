using System.Collections.Generic;
using NHibernate;

namespace EM.Calc.DB
{
    public class NHResultOperationRepository : IEntityRepository<ResultOperation>
    {
        public ResultOperation Create(ResultOperation ResultOperation)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            using (var transaction = session.BeginTransaction())
            {
                var entity = session.Get<ResultOperation>(id);
                entity.Status = OperationResultStatus.EXECUTING;
                session.Update(entity);
                transaction.Commit();
            }
            NHibernateHelper.CloseSession();
        }

        public IEnumerable<ResultOperation> GetAll()
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            var list = session.CreateCriteria<ResultOperation>()
                .List<ResultOperation>();

            NHibernateHelper.CloseSession();

            return list;
        }

        public ResultOperation Load(long id)
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            var entity = session.Load<ResultOperation>(id);

            NHibernateHelper.CloseSession();

            return entity;
        }

        public void Save(ResultOperation ResultOperation)
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            using (var transaction = session.BeginTransaction())
            {
                session.Save(ResultOperation);
                transaction.Commit();
            }
            NHibernateHelper.CloseSession();
        }
    }
}
