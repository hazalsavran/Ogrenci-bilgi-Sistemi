using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;


namespace EntityAsp
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        UrunTakipEntities DB = new UrunTakipEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var degerler = DB.Kategoriler.ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
           
          
        }
    }
}