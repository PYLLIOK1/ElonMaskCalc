using System.Collections.Generic;

namespace EM.Calc.DB
{
    public interface IEntityRepository<T> where T : class, IEntity
    {
        T Create(T entity);

        T Load(long id);

        void Save(T entity);

        void Delete(long id);

        IEnumerable<T> GetAll();
    }
}
