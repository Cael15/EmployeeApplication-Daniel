using BL.Interfaces.UnitOfWork;
using Core.Interfaces.DL;
using Data.Repositories;
using DL.Data;
using DL.Repositories;
using Microsoft.Extensions.Configuration;

namespace DL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeDbContext _dbContext;
        private readonly IConfiguration _configuration;
        private readonly IEmployeeClientRepository _employeeClientRepository;
        private readonly IEmployeeRepository _employeeRepository;

        public UnitOfWork(EmployeeDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        public IEmployeeClientRepository EmployeeClientRepository => _employeeClientRepository ?? new EmployeeClientRepository(_dbContext, _configuration);

        public IEmployeeRepository EmployeeRepository => _employeeRepository ?? new EmployeeRepository(_dbContext);

        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
