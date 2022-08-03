using Core.Interfaces.DL;
using System;

namespace BL.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeClientRepository EmployeeClientRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }

        void SaveChanges();
        
    }
}
