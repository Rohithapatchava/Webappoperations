using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webappoperations
{
    public partial class showastudentpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(Object sender, EventArgs e)
        {
            adodatalayer ad1 = new adodatalayer();
            int idno = Convert.ToInt32(TextBox1.Text);
            var singlestudent = ad1.GetaStudent(idno);
            GridView1.DataSource = singlestudent;
            GridView1.DataBind();
        }
    }
}