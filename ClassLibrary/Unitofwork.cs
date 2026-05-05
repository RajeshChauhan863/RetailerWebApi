using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitofWork
{
    public class Unitofwork : IUnitofWork
    {
        private readonly PosRetailContext _context;
        private ICustomerRepository<Customer> _customerRepository;

        public Unitofwork(PosRetailContext context)
        {
            _context = context;
        }

        public ICustomerRepository<Customer> CustomerRepository
        {
            get
            {
                return _customerRepository ??= new CustomerRepository(_context);
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
