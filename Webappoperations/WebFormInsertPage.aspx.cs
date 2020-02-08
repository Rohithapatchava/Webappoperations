using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webappoperations
{
    public partial class WebFormInsertPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            adodatalayer ad1 = new adodatalayer();
            int idno = Convert.ToInt32(TextBox1.Text);
            string name = (TextBox2.Text);
            string course =(TextBox3.Text);
           string date =(TextBox4.Text);
            var insert = ad1.InsertData(idno,name,course,date);
            GridView1.DataSource = insert;
            GridView1.Dispose();
        }
    }
}