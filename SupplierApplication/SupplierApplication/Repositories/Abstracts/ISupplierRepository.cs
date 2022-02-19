using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupplierApplication.Repositories.Abstracts
{
    public interface ISupplierRepository<T>
    {
        Task<T> Create(T _object);
        void Update(T _object);
        IEnumerable<T> GetAll();
        T GetById(int Id);
        void Delete(T _object);
    }
}
