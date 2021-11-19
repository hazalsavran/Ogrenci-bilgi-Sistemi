using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp.Müşteri
{
    public partial class Musteriler : System.Web.UI.Page
    {
        UrunTakipEntities db = new UrunTakipEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var degerler = db.Musteriler.ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
            
            
        }
    }
}