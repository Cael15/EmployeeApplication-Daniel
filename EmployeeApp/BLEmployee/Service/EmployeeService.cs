using BL.Interfaces.UnitOfWork;
using Core.Interfaces.Service;
using Core.Model.Entity;
using System;

namespace BL.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Employee employee)
        {
            var findEmployee = _unitOfWork.EmployeeRepository.GetById(employee.ID);
            if (findEmployee == null)
                throw new Exception("This employee Id doesn't exist");
            _unitOfWork.EmployeeRepository.Add(employee);
            _unitOfWork.SaveChanges();

        }

        public bool Update(Employee employee)
        {
            Employee editEmployee = _unitOfWork.EmployeeRepository.GetById(employee.ID);
            editEmployee.Name = employee.Name;
            editEmployee.RoleName = employee.RoleName;
            _unitOfWork.EmployeeRepository.Update(editEmployee);
            _unitOfWork.SaveChanges();
            return true;
        }
    }
}
