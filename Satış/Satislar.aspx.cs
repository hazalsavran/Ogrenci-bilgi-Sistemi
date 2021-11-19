using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp.Satış
{
    public partial class Satislar : System.Web.UI.Page
    {
        UrunTakipEntities db = new UrunTakipEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var Satışlar = db.Satış.ToList();
            var Satışlar = (from x in db.Satış
                            select new
                            {
                                x.SatışID,
                                x.Urunler.UrunAd,
                                x.Personeller.PersonelAdSoyad,
                                x.Musteriler.MusteriAdSoyad,
                                x.Fiyat
                            }).ToList();
            Repeater1.DataSource = Satışlar;
            Repeater1.DataBind();


            if (Page.IsPostBack == false)
            {
                var urun = (from x in db.Urunler select new { x.UrunID, x.UrunAd }).ToList();

                DropDownList1.DataTextField = "UrunAd";
                DropDownList1.DataValueField = "UrunID";
                DropDownList1.DataSource = urun;
                DropDownList1.DataBind();

                var musteri = (from x in db.Musteriler select new { x.MusteriID, x.MusteriAdSoyad }).ToList();

                DropDownList2.DataTextField = "MusteriAdSoyad";
                DropDownList2.DataValueField = "MusteriID";
                DropDownList2.DataSource = musteri;
                DropDownList2.DataBind();

                var personel = (from x in db.Personeller select new { x.PersonelID, x.PersonelAdSoyad }).ToList();

                DropDownList3.DataTextField = "PersonelAdSoyad";
                DropDownList3.DataValueField = "PersonelID";
                DropDownList3.DataSource = personel;
                DropDownList3.DataBind();


                


            }   
        



        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Entity.Satış satış = new Entity.Satış();
            satış.Musteri =int.Parse( DropDownList2.SelectedValue);
            satış.Urun = int.Parse(DropDownList1.SelectedValue);
            satış.Personel = byte.Parse(DropDownList3.SelectedValue);
            satış.Fiyat = decimal.Parse(TextBox4.Text);
            db.Satış.Add(satış);
            db.SaveChanges();
            Response.Redirect("Satislar.aspx");



        }
    }
}