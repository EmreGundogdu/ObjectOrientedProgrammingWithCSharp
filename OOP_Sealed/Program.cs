class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        C c = new();
        c.X(); //B class'ındaki davranış sergilenicek
    }
}


#region Üst class'tan alt class'a kalıtım verilmesini istemiyorsak base class'ı 'sealed' ile işaretlemeliyiz
//Üst class'ın alt class'a kalıtım vermesini istemiyorsak o class'ı sealed ile işaretlememliyiz.

//sealed class A
//{

//}
//class B:A
//{

//}
#endregion


#region Metot seviyesinde sealed keywordü
class A
{
    public virtual void X()
    {
        Console.WriteLine("A");
    }
}
class B : A
{
    sealed public override void X() //1.)bu noktada sealed keywordü kullandığımız için c class'ında base class olan a clas'ından virtual metodu artık override edemeyiz
    {
        Console.WriteLine("B");
    }
}
class C : B
{
    //public override void X()
    //{
    //    Console.WriteLine("C");  2.) Main metodunda c nesnesindeki x metodu b metodunu temsil ediyor
    //}
}
#endregion

#region Sealed keywordü hakkında bilgiler
/*
 * Sınıfların davranışlarını korumak istediğimizde: Kalıtımsal hiyerarşide üst sınıfların özel metotları/davranışları varsa ve bu metotlardaki davranışların alt sınıflar tarafından değiştirilebilir olmasını istemediğimiz durumlarda, o metodu sealed olarak işaretleyebiliriz.
 * 
 * Performasın İyileştirmesi İstendiğinde: Mikro seviyede yapılan bir optimizasyon neticesinde C#'ta bir sınıf sealed ile işaretlendiğinde sealed olmayan bir sınıfa göre ufak çapta bir performans artığı göstermiştir. Bunun nedeni,derleyicinin sealed ile işaretlenmiş sınıfın miras alınmayacğını bilerek daha hızı derleme yapmasıdır.
 * 
 * 
 * Singleton Design Pattern: Singleton Design Pattern'da bir sınıfın uygulama çağında tekil bir instancenin olması amaçlanmaktadır. Haliyle ilgili sınıf sealed ile işaretlenerek, bu sınıftan herhangi bir kalıtımsal ilişkinin yaratılmasını engelleyebilir ve tek instance üretimini daha da garanti hale getirmiş oluruz.
 */
#endregion