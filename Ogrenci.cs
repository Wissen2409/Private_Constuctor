using System.Data.Common;

public class Ogrenci{

    public int Id;
    public string Name;

    public int OkulNo;
    public Ogrenci()
    {
        this.OkulNo=5;
    }

    // öğrenci no alsın diye default ctor'a yönlendirildi.
    public Ogrenci(int id,string name):this(){

        this.Id=id;
        this.Name=name;
    }
}