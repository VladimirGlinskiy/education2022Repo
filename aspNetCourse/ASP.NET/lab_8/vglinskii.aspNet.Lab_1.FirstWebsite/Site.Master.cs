using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vglinskii.aspNet.Lab_1.FirstWebsite
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            long numVisitors = 0;

            if (Application["Visitors"] != null)
            { 
                numVisitors = long.Parse(Application["Visitors"].ToString());
            }

            String s = "Число посещений: " + numVisitors.ToString();
            VisitorLiteral.Text = s;
        }
    }
}