using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp.Login_Form
{
    public partial class Login : System.Web.UI.Page
    {

        UrunTakipEntities db = new UrunTakipEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.Admin where x.Kullanıcı == TextBox1.Text && x.Sifre == TextBox2.Text select x;
            if (sorgu.Any())
            {
                Response.Redirect("Anasayfa.aspx");
            }
            else
            {
                Response.Write("Kullanıcı Adı veya Şifre Hatalı");
            }
        }
    }
}