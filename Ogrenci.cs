using System.Data.Common;

public class Ogrenci{

    public int Id;
    public string Name;

    public int OkulNo;


    // default ctor, nesne üretilirken kullanılmaması sağlanabilir.
    // default ctor'u dış dünyaya kapatmak için private keywordünü kullanıyoruz

    // her ctor private işaretlenerek, dış dünyaya kapanabilir
    // bunun kararını yazılımcı kişisi kendi tasarladığı plana göre uygulayabilir.!!!
    private Ogrenci()
    {
        this.OkulNo=5;
    }

    // öğrenci no alsın diye default ctor'a yönlendirildi.
    public Ogrenci(int id,string name):this(){

        this.Id=id;
        this.Name=name;
    }
}