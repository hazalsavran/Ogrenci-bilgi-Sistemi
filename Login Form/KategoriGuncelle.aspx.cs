using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;


namespace EntityAsp
{
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        UrunTakipEntities db = new UrunTakipEntities();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)//sayfanın yeniden yüklenip eski değere göre güncelleme yapmamasını sağlıyor
            {
                int id = Convert.ToInt32(Request.QueryString["KategoriID"]);
                TextBox1.Text = id.ToString();
                var kategoriAd = db.Kategoriler.Find(id);
                TextBox2.Text = kategoriAd.KategoriAd;

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["KategoriID"]);
            var ktgr = db.Kategoriler.Find(id);
            ktgr.KategoriAd = TextBox2.Text;
            db.SaveChanges();
            Response.Redirect("Anasayfa.aspx");

        }
    }
}