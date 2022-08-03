using Core.Interfaces.DL;
using Core.Model.Entity;
using DL.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeDbContext context) : base(context) 
        {

        }
    }
}
