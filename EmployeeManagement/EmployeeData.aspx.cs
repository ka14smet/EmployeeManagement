using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeBEL;
using EmployeeBLL;

namespace EmployeeManagement
{
    public partial class EmployeeData : System.Web.UI.Page
    {

        Employee objBEL = new Employee();
        EmployeeBusiness objBLL = new EmployeeBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click()
        {
            objBEL.Name = txtname.Text.Trim();
            objBEL.Age = Convert.ToInt32(txtAge.Text.Trim());
            objBEL.Email = txtEmail.Text.Trim();

            try
            {
                int retVal = objBLL.SaveEmployeeDetails(objBEL);

                if(retVal > 0)
                {
                    lblStatus.Text = "Employee Added Successfully";

                        
                }
                else
                {
                    lblStatus.Text = "Employee Not Added Successfully";
                }
            }

            catch(Exception ex)
            {
                throw;
            }
        }
    }
}