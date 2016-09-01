using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DISC3._5
{
    public partial class MenuUsr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnregresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}