using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KullaniciMetot1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int sonuc = Topla(15, 40);
            //Label1.Text += sonuc.ToString();

            string gelen = AdNot("Berat", 45);
            Label1.Text += gelen; 
        }

        public static int Topla(int x, int y)
        {
            int sonuc;
            sonuc = x + y;
            return sonuc;
        }

        public static string AdNot(string ad, float notu)
        {
            string donusdegeri = ad;
            if (notu < 50)
                donusdegeri += " dersten kaldı.";
            else
                donusdegeri += " dersten geçti.";
            return donusdegeri;
        }
    }
}