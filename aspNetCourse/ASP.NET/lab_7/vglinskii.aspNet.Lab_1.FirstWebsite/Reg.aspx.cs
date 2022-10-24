using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vglinskii.aspNet.Lab_1.FirstWebsite
{
    public partial class Reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) {

                Page.Validate();
                if (!Page.IsValid) { 
                return;
                }

                GuestResponse response = new GuestResponse(name.Text, email.Text, phone.Text, CheckBoxYN.Checked);
            
                ResponseRepository.GetRepository().AddResponse(response);

                if (response.WillAttend.HasValue && response.WillAttend.Value)
                {
                    Response.Redirect("seeyouthere.html");
                }
                else {

                    Response.Redirect("sorryyoucantcome.html");
                }
            
            }

            


        }
    }
}