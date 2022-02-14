//Bir nesnenin, birden fazla referansla işaretlenmesi; o nesnenin, birden fazla türün davranışlarını gösterebilmesini sağlar
MyClass2 myClass = new MyClass();
A a = new B();
B b = new B();
C c = new B();
C c2 = new C();
Insan insan = new Erkek();
Insan insan2 = new Kadin();
class MyClass : MyClass2
{

}
class MyClass2
{

}

class A : C
{
    public void X()
    {

    }
}
class B : A
{
    public void Y()
    {

    }
}
class C
{
    public void Z()
    {

    }
}
class Insan
{

}
class Erkek : Insan
{

}
class Kadin : Insan
{

}
class Arac
{
    public virtual void Calistir()
        => Console.WriteLine("Araç Çalıştı");
}
class Taksi : Arac
{
    public override void Calistir()
        => Console.WriteLine("Taksi Çalıştı");
}
//Bir sınıftan aynı sınıf ile bir nesne oluşturduğumuz zaman cast işlemi ile Üst sınıftan alt sınıfa referans vermek/işaretlemek istersek bunu sağlayabiliriz. Örnek A classı var ve B classı olsun; A class(base), B class(derived). B classından bir nesne oluşturduğumuz zaman bunu şu şekilde cast operatörü ile A referansı ile işaretleyebiliriz. ÖRNEK;
//A a = new B();


//Başka bir sınıftan veya alt sınıftan bir classı üst sınıflardan oluşmuş bir nesne ile cast operatörü kullanılarak referans edilemez/işaretlenemez
//Aralarında kalıtım olan ya da polimorfizm kuralları gereği şu şekilde olabilir
//B b = new B();
//(A)b; gibi


//BU OLAMAZ;
//D(b); D class'ı cast operatörü ile referans edilemez arada bir bağ yok kalıtım veya polimorfizm gibi


//Cast operatörü hata verir uygulamayı sonlandırır. As operatörü bi hata durumunda null hatası verir uygulamay çalışır.