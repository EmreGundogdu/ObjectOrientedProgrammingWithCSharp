﻿Muhasabeci muhasabeci = new();
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
    public MyClass()
    {

    }
    public MyClass(string a)
    {

    }
    public MyClass(int a, string b)
    {

    }
}
class MyClass2 : MyClass
{
    //Bir class üzerinden nesne oluşturulurken o nesnenin base classında ki bir constructoru seçip ona göre bir base class'tan nesne üretmek istersek eğer, derived classa gelip constructor kısmına 'base' keywordünü kullanıp base class'ta bulunan constructor'a parametreleri veriyoruz...Base keywordünü kullanmadığımı zaman derived class'tan nesne oluşturacağımız zaman base classtan da nesne oluşturacağı için ve base classta parametre alan bir constructor olduğunu varsayarsak bizden nesne oluştururken bizden parametre vermemizi isteyecektir ve bize hata vericektir.
    //Eğer ki base class'ta boş parametreli bir constructor varsa derived classta base ile bir bildirimde bulunmak zorunda değiliz.... Çünkü varsayılan olarak kalıtımsal durumda base classtaki boş parametreleri constructor tetiklenir.
    //Bir class'ın constructorunın yanında : base( ... ) keywordünü kullanırsak eğer o classın base classının tüm constructorlarını bize getirecektir. Haliyle ilgili sınıftan bir nesne üretilirken base classtan nesne üretimi esnasında hangi constructorun tetikleyeceğini bu şekilde belirleyebiliriz yani overloadlarına bakarız.
    public MyClass2():base(5,"sdasdsadasdsa")//nesne oluştururken bu constructor tetiklenicek
    {

    }
    //Eğer ki base class'ın constructoru sadece parametre alan bir constructor ise deriverd class(alt class)'larda o constructor'a bir değer göndermek zorundayız. Bunuda base keywordüyle sağlıyoruz.
    public MyClass2(int a) : base(a)
    {

    }
}