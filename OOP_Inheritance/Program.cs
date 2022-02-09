Muhasabeci muhasabeci = new();
Mudur Mudur = new();
//Bir class'ın sadece bir tane Base Class'ı olur
//Bir sınıftan nesne üretimi yapılırken kalıtım aldığı üst sınıflar varsa eğer önce o sınıflardan SIRAYLA nesne üretilir. Örnek : C classı B classının alt classı olsun ve B class'ı da A class'ının alt classı olsun. C classından nesne üretmek istediğimiz zaman Önce A, sonra B ve sonra da C classlarından sıraysıyla nesneler üretilecektir.
new D();
class Personel
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public bool MedeniHal { get; set; }
}
class Muhasabeci : Personel
{

}
class Yazıilimci : Personel
{
    public string[] KullandigiDiller { get; set; }
}
class Mudur : Personel
{

}
class BuyukBaba
{

}
class Baba : BuyukBaba
{

}
class Ogul : Baba
{

}
class A
{
    public A()
    {
        Console.WriteLine($"{nameof(A)} nesnesi oluşturuldu");
    }
}
class B : A
{
    public B()
    {
        Console.WriteLine($"{nameof(B)} nesnesi oluşturuldu");
    }

}
class C : B
{
    public C()
    {
        Console.WriteLine($"{nameof(C)} nesnesi oluşturuldu");
    }
}
class D : C
{
    public D()
    {
        Console.WriteLine($"{nameof(D)} nesnesi oluşturuldu");
    }
}
class MyClass
{
    public MyClass(int a)
    {

    }
}
class MyClass2 : MyClass
{
    //Bir class üzerinden nesne oluşturulurken o nesnenin üst classında ki bir constructoru seçip ona göre bir üst class'tan nesne üretmek istersek eğer, alt classa gelip constructor kısmına 'base' keywordünü kullanıp üst class'ta bulunan constructor'a parametreleri veriyoruz...Base keywordünü kullanmadığımı zaman alt class'tan nesne oluşturacağımız zaman üst classtan da nesne oluşturacağı için ve üst classta parametre alan bir constructor olduğunu varsayarsak bizden nesne oluştururken bizden parametre vermemizi isteyecektir ve bize hata vericektir.
    public MyClass2() : base(5)
    {

    }
}