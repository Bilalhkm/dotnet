Calisan bilal = new();
bilal.Ad = "Bilal";

class Calisan
{
    public Calisan(string ad, string soyAd, int no, string departman)
    {
        this.Ad = ad;
        this.SoyAd = soyAd;
        this.No = no;
        this.Departman = departman;
    }
    public Calisan()
    {

    }
    public string Ad;
    public string SoyAd;
    public int No;
    public string Departman;
    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisan Adi:{0}", Ad);
        Console.WriteLine("Calisan soyAdi:{0}", SoyAd);
        Console.WriteLine("Calisan No:{0}", No);
        Console.WriteLine("Calisan departmani:{0}", Departman);
    }
}