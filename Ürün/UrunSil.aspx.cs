using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp
{
    public partial class UrunSil : System.Web.UI.Page
    {
        UrunTakipEntities db = new UrunTakipEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["UrunID"]);
            var urun = db.Urunler.Find(id);
            urun.Durum = false;
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");

            
            
        }
    }
}