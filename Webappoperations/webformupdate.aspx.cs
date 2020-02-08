using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webappoperations
{
    public partial class webformupdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            adodatalayer ad1 = new adodatalayer();
            int idno = Convert.ToInt32(TextBox1.Text);
            string date = (TextBox2.Text);
            var update = ad1.UpdateStudent(idno, date);
            GridView1.DataSource = update;
            GridView1.Dispose();
        }
    }
}