using Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces.Service
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        bool Update(Employee employee);
    }
}
