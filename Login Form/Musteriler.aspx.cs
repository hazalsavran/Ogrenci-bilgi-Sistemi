using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp
{
    public partial class Musteriler : System.Web.UI.Page
    {
        UrunTakipEntities db = new UrunTakipEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var musteriler = db.Musteriler.ToList();
            
            Repeater1.DataSource = musteriler;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Entity.Musteriler musteriler = new Entity.Musteriler();
            musteriler.MusteriAdSoyad = TextBox1.Text;
            db.Musteriler.Add(musteriler);
            db.SaveChanges();
            Response.Redirect("Musteriler.aspx");


        }
    }
}