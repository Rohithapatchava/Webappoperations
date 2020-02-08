using System;

namespace Webappoperations
{
    public partial class webformdata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                adodatalayer al = new adodatalayer();
                var stlist = al.Getallrecords();
                GridView1.DataSource = stlist;
                GridView1.DataBind();

                /*adodatalayer a2 = new adodatalayer();
                var stlist1 = a2.Insertrecords();
                GridView1.DataSource = stlist1;
                GridView1.Dispose()*/

            }
        }

    }
}
