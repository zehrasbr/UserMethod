using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KullaniciMetot1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int gelenveri = WebForm1.Topla(10, 20);
            //Label1.Text += gelenveri.ToString();

            Label1.Text += WebForm1.AdNot("Ece", 80);
        }
    }
}