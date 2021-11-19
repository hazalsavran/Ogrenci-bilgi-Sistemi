using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp.Ürün
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        UrunTakipEntities db = new UrunTakipEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)//sayfanın yeniden yüklenip eski değere göre güncelleme yapmamasını sağlıyor
            {
                int id = Convert.ToInt32(Request.QueryString["UrunID"]); // id yi çek              
                var ur = db.Urunler.Find(id); // o id nin indexindeki verileri çek (ad,marka,stok vs..) 
                var kategori = (from x in db.Kategoriler select new { x.KategoriID, x.KategoriAd }).ToList();

                DropDownList1.DataTextField = "KategoriAd";
                DropDownList1.DataValueField = "KategoriID";
                DropDownList1.DataSource = kategori;
                DropDownList1.DataBind();

                TextBox1.Text = ur.UrunAd;
                TextBox2.Text = ur.UrunMarka;
                DropDownList1.SelectedValue = ur.UrunKategori.ToString();
                TextBox4.Text = ur.UrunFiyat.ToString();
                TextBox5.Text = ur.UrunStok.ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["UrunID"]);
            var ur = db.Urunler.Find(id);
            ur.UrunAd= TextBox1.Text;
            ur.UrunMarka = TextBox2.Text;
            ur.UrunFiyat =decimal.Parse( TextBox4.Text);
            ur.UrunStok = short.Parse( TextBox5.Text);
            ur.UrunKategori = byte.Parse( DropDownList1.SelectedValue.ToString());
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}