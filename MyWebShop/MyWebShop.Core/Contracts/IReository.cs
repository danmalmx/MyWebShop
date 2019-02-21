using System.Linq;
using MyWebShop.Core;

namespace MyWebShop.Core.Contracts
{
    public interface IReository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(string Id);
        T Find(string Id);
        void Insert(T t);
        void Update(T t);
    }
}