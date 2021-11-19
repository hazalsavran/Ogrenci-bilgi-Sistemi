using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;


namespace EntityAsp.Ürün
{
    public partial class Urunler : System.Web.UI.Page
    {
        UrunTakipEntities db = new UrunTakipEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var urunler = db.Urunler.Where(x => x.Durum == true).ToList();

            //Linq sorgusu ama where yerine istediğimiz alanları getirttik ve listeledik
            var urunler = (from x in db.Urunler where x.Durum==true
                           select new
                           {
                               x.UrunID,
                               x.UrunAd,
                               x.UrunMarka,
                               x.Kategoriler.KategoriAd, //Urunler sayfasındaki evale verdiğimiz kategori adını burdan çektiriyoruz
                               x.UrunFiyat,
                               x.UrunStok,

                           }).ToList();
            Repeater1.DataSource = urunler;
            Repeater1.DataBind();

            if (Page.IsPostBack==false)
            {
                var kategori = (from x in db.Kategoriler select new { x.KategoriID, x.KategoriAd }).ToList();

                DropDownList1.DataTextField = "KategoriAd";
                DropDownList1.DataValueField = "KategoriID";
                DropDownList1.DataSource = kategori;
                DropDownList1.DataBind();
            }
           
           
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Entity.Urunler yeniurun = new Entity.Urunler();
            yeniurun.UrunAd = TextBox1.Text;
            yeniurun.UrunMarka = TextBox2.Text;
            yeniurun.UrunKategori = byte.Parse( DropDownList1.Text);
            yeniurun.UrunFiyat =decimal.Parse( TextBox4.Text);
            yeniurun.UrunStok =short.Parse( TextBox5.Text);
            yeniurun.Durum = bool.Parse("True");
            db.Urunler.Add(yeniurun);
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");


        }
    }
}