using DAL.Models;
using Repository;

namespace UnitofWork
{
    public interface IUnitofWork : IDisposable
    {
        ICustomerRepository<Customer> CustomerRepository { get; }
        void SaveChanges();
    }
}
