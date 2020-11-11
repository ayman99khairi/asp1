using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace alaa1
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_click(object sender, EventArgs e)
        {
            TextBox2.Text = TextBox1.Text;
            TextBox1.Text=string.Empty;
        }
    }
}