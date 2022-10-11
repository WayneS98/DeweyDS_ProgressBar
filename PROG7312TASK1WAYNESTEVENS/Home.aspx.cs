using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROG7312TASK1WAYNESTEVENS
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnReplace_Click(object sender, EventArgs e)
        {
            //THIS WILL DIRECT THE CLIENT TO THE REPLACING TAB
            Response.Redirect("ReplacingBooks.aspx");          
           
        }

        protected void BtnIdentify_Click(object sender, EventArgs e)
        {
            //THIS WILL REDIRECT THE CLIENT TO THE INDENTIFYING AREA PAGE
            Response.Redirect("IdentifyingAreas.aspx");
        }
    }
} 