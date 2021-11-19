using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp
{
    public partial class KategoriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UrunTakipEntities db = new UrunTakipEntities();
            Kategoriler yenikategori = new Kategoriler();
            yenikategori.KategoriAd = TextBox1.Text;
         
            db.Kategoriler.Add(yenikategori);
            db.SaveChanges();
            Response.Redirect("Anasayfa.aspx");
        }
    }
}