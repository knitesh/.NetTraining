using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Basic_Training_Part_3
{
    public class BaseEmployee
    {
        //Error, given the address of objects is determined at runtime
        // public const Employee HrEmployee = new Employee(1,"Hr1");

        public readonly  BaseEmployee HrEmployee = new BaseEmployee(1, "Hr1");

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        internal BaseEmployee()
        {
        }

        internal BaseEmployee(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
        }
    }
}
