using System;
using System.Collections.Generic;
using System.Text;

namespace DL.DTO
{
    public class CreateEmployeeDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }
    }
}
