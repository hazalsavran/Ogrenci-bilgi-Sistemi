using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp
{
    public partial class KategoriSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UrunTakipEntities db = new UrunTakipEntities();
            int x = Convert.ToInt32(Request.QueryString["KategoriID"]);
            var deger = db.Kategoriler.Find(x);
            db.Kategoriler.Remove(deger);
            db.SaveChanges();
            Response.Redirect("Anasayfa.aspx");

        }
    }
}