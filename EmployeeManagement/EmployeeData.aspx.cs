using System;
using System.Collections.Generic;
using System.Data;
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
            if (!Page.IsPostBack)
            {
                BindEmpRecords();
            }
        }



        protected void grdEmpDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdEmpDetails.PageIndex = e.NewPageIndex;
            BindEmpRecords();
        }

        protected void grdEmpDetails_RowcancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdEmpDetails.EditIndex = -1;
            BindEmpRecords();
        }

        
        protected void grdEmpDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdEmpDetails.EditIndex = e.NewEditIndex;
            BindEmpRecords();
        }

        private void BindEmpRecords()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = objBLL.GetEmpRecords();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    grdEmpDetails.DataSource = ds;
                    grdEmpDetails.DataBind();
                }
                else
                {
                    grdEmpDetails.DataSource = null;
                    grdEmpDetails.DataBind();
                }
            }
            catch(Exception ex)
            {
                Response.Write("Error Occured: " + ex.Message.ToString());
            }
            finally
            {
                objBEL = null;
                objBLL = null;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
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

        protected void grdEmpDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            objBEL.ID = Convert.ToInt32(grdEmpDetails.DataKeys[e.RowIndex].Value);
            objBEL.Name = ((TextBox)(grdEmpDetails.Rows[e.RowIndex].FindControl("txtEmpnameEdit"))).Text.Trim();
            objBEL.Age = Convert.ToInt32(((TextBox)(grdEmpDetails.Rows[e.RowIndex].FindControl("txtEmpAgeEdit"))).Text.Trim());
            objBEL.Email = ((TextBox)(grdEmpDetails.Rows[e.RowIndex].FindControl("txtEmpEmailEdit"))).Text.Trim();

            try
            {
                int retVal = objBLL.UpdateEmployeeDetails(objBEL);
                if (retVal > 0)
                {
                    lblStatus.Text = "Emp detials updated succesfully";
                    lblStatus.ForeColor = System.Drawing.Color.Green;

                    grdEmpDetails.EditIndex = -1;
                    ClearControls();
                    BindEmpRecords();
                }
            }
            catch(Exception ex)
            {
                Response.Write("Error occured" + ex.Message.ToString());
            }


        }

        private void ClearControls()
        {
            txtname.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtEmail.Text = string.Empty;

        }
    }
}