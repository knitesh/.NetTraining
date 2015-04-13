using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Net_Basic_Training_Part_3
{
   public interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        string Department { get; set; }
        double CalculateSalary(double dblTotalHour, double dblHourlyRate);
    }
}
