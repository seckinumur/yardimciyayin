using ProjectMercury.Entity.DBContext;
using ProjectMercury.Entity.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMercury.DAL.Repository
{
   public class SiteSifirla
    {
        public static bool Format()
        {
            using (DBCON db = new DBCON())
            {
                try
                {
                    try
                    {
                        var silurun = db.Urun.ToList();
                        db.Urun.RemoveRange(silurun);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Uruns', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    try
                    {
                        var AK = db.AltKategori.ToList();
                        db.AltKategori.RemoveRange(AK);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.AltKategoris', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    try
                    {
                        var AC = db.AylikCiro.ToList();
                        db.AylikCiro.RemoveRange(AC);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.AylikCiros', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    try
                    {
                        var ES = db.EnCokSatan.ToList();
                        db.EnCokSatan.RemoveRange(ES);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.EnCokSatans', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    try
                    {
                        var GC = db.GunlukCiro.ToList();
                        db.GunlukCiro.RemoveRange(GC);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.GunlukCiros', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    try
                    {
                        var KT = db.Kategori.ToList();
                        db.Kategori.RemoveRange(KT);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Kategoris', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    try
                    {
                        var KL = db.Kullanicilar.ToList();
                        db.Kullanicilar.RemoveRange(KL);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Kullanicilars', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    try
                    {
                        var MA = db.Marka.ToList();
                        db.Marka.RemoveRange(MA);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Markas', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    try
                    {
                        var SS = db.SanalSepet.ToList();
                        db.SanalSepet.RemoveRange(SS);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.SanalSepets', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    try
                    {
                        var SU = db.SanalSepetUye.ToList();
                        db.SanalSepetUye.RemoveRange(SU);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.SanalSepetUyes', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    try
                    {
                        var SE = db.Sepet.ToList();
                        db.Sepet.RemoveRange(SE);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Sepets', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    try
                    {
                        var SI = db.Siparis.ToList();
                        db.Siparis.RemoveRange(SI);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Sipariss', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    try
                    {
                        var SB = db.SiteBilgileri.ToList();
                        db.SiteBilgileri.RemoveRange(SB);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.SiteBilgileris', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    try
                    {
                        var SL = db.Slider.ToList();
                        db.Slider.RemoveRange(SL);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Sliders', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    try
                    {
                        var UK = db.UrunKategori.ToList();
                        db.UrunKategori.RemoveRange(UK);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.UrunKategoris', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    try
                    {
                        var UE = db.Uyeler.ToList();
                        db.Uyeler.RemoveRange(UE);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Uyelers', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }
                    
                    db.Kategori.Add(new Kategori
                    {
                        KategoriAdi = "KPSS Kitapları"
                    });
                    db.SaveChanges();

                    db.AltKategori.Add(new AltKategori
                    {
                        AltKategoriAdi = "KPSS Eğitim Bilimleri",
                        KategoriID = 1
                    });
                    db.SaveChanges();

                    db.UrunKategori.Add(new UrunKategori
                    {
                        UrunKategoriAdi = "KPSS Konu Anlatımı",
                        AltKategoriID = 1
                    });
                    db.SaveChanges();

                    db.Marka.Add(new Marka
                    {
                        MarkaAdi = "Lider Yayınları"
                    });
                    db.SaveChanges();

                    db.Urun.Add(new Urun
                    {
                        AltKategoriID = 1,
                        IndirimliFiyati = 35.70,
                        IndirimVarmi = true,
                        KategoriID = 1,
                        MarkaID = 1,
                        UrunAciklama = "1456 Sayfa 19.50 x 27.50 cm 1.Hamur Kağıt Poşet Ambalaj Program Geliştirme, Öğrenme Psikolojisi, Gelişim psikiolojisi, Rehberlik Ve Özel Eğitim, Öğretim Yöntem Ve Teknikleri, Ölçme Ve Değerlendirme.",
                        UrunAdedi = 1,
                        UrunAdi = "Murat Yayınları KPSS Eğitim Bilimleri Konu Anlatımlı Modüler Set(2017)",
                        UrunFiyati = 59.50,
                        UrunKategoriID = 1,
                        Image = "/images/ImageStore/Demo.JPG"
                    });
                    db.SaveChanges();

                    db.Kullanicilar.Add(new Kullanicilar
                    {
                        KullaniciAdi = "admin",
                        KullaniciSifre = "9916",
                        Master = true,
                        System = true
                    });
                    db.SaveChanges();
                    db.Kullanicilar.Add(new Kullanicilar
                    {
                        KullaniciAdi = "demo",
                        KullaniciSifre = "1234",
                        Master = true,
                        System = false
                    });
                    db.SaveChanges();
                    db.Uyeler.Add(new Uyeler
                    {
                        Sifre = "1234",
                        Adres = "demo adres",
                        Banlimi = false,
                        MailAdresi = "seckinumur@gmail.com",
                        Tarih = DateTime.Now.ToShortDateString(),
                        Telefon = "05423428009",
                        UyeAdiSoyadi = "demo demo",
                        Il = "İzmir",
                        not=null
                    });
                    db.SaveChanges();

                    db.SiteBilgileri.Add(new SiteBilgileri()
                    {
                        Adres = "Karşıyaka/İZMİR",
                        Facebook = "https://www.facebook.com/seckinumur85",
                        Instagram = "#",
                        Telefon = "#",
                        MailAdresi = "seckinumur@gmail.com",
                        MobilTelefon = "tel:+905423428009",
                        SiteAdi = "Choice Admin Control Systems V.1.5",
                        Twitter = "https://twitter.com/SeckinUmur",
                        Whatsapp = "+905423428009",
                        Logo = "/images/Company/projectmercury.PNG",
                        Hakkinda = "©2017 Choice Corporation All Rights Reserved.",
                        FLogo = "/images/Company/favicon.PNG"
                    });
                    db.SaveChanges();

                    db.Slider.Add(new Slider()
                    {
                        Image = "/images/Company/Slider/Slider1.JPG"
                    });
                    db.SaveChanges();

                    db.Slider.Add(new Slider()
                    {
                        Image = "/images/Company/Slider/Slider2.JPG"
                    });
                    db.SaveChanges();

                    db.Slider.Add(new Slider()
                    {
                        Image = "/images/Company/Slider/Slider3.JPG"
                    });
                    db.SaveChanges();

                    db.Slider.Add(new Slider()
                    {
                        Image = "/images/Company/Slider/Slider4.JPG"
                    });
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
