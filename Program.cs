// default ctor, 

// eğer siz default ctor içerisinde, diğer ctorlara yarımcı bazi şeyler yapıyorsanız.
// eğer default ctor tek başına bir iş yapamayıp hep diğer ctorlar ile bağlantılı çalışıyorsa,
// default ctor üzerinden nesne üretmeyi kapatmalıyız


Ogrenci o = new Ogrenci(5,"Mehmet");
Ogrenci o1 = new Ogrenci();
Console.WriteLine(o1.Name);