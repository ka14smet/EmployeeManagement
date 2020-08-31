using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeBEL;
using EmployeeDAL;

namespace EmployeeBLL
{
    public class EmployeeBusiness
    {
        public int SaveEmployeeDetails(Employee objBEL)
        {
            EmployeeAccess objDAL = new EmployeeAccess();
            try
            {
                return objDAL.SaveEmployeeDetails(objBEL);
            }
            catch
            {
                throw;
            }

            finally
            {
                objDAL = null;
            }
        }
    }
}
