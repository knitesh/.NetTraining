using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Basic_Training_Part_3
{
    public  class ReadOnlyData
    {
       public  void DisplayData()
       {
           var value = ConstData.PI;

          //var objEmployee = new BaseEmployee();
           ////Error can't change the value for the readonly field
           //var r = BaseEmployee.HrEmployee;
       }
    }
}
