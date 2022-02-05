#region Field
//Field : Nesne içerisinde değer tutmamızı sağlayan alanlardır.
//Class içerisinde tanımlanan fieldlara kendi türün default değerler verilir. Metot içerisinde tanımlanan değişkenlere default değer verilmez.
#endregion
#region Property
//Nesne içerisinde özellik/property sağlar.
//Property esasında özünde bir metottur. Yani programatik/algoritmik kodlarımızı inşa ettiğimiz bir metot.
#endregion
#region Encapsulation(Kapsülleme/Sarmalama)
//Encapsulation, bir nesne içerisindeki dataların(field'lardaki verilen) dışarıya kontrollü bir şekilde açılmasını ve kontrollü bir şekilde veri almasıdır.
#endregion
MyClass myClass = new MyClass(); //Nesne oluşturma
Console.WriteLine(myClass.Yasi); //get blogu tetiklenir
myClass.Yasi = 21; //set blogu tetiklenir.
myClass.X();
myClass.X(4, 5);
myClass[5] = 10;
Console.WriteLine(myClass[5]);
MyClass2 myClass2 = new MyClass2();
MyClass2.MyClass3 myClass3 = new MyClass2.MyClass3();
myClass2.X(5);
MyClass4 myClass4 = new MyClass4();
myClass4.X();
//Oluşturduğumuz yapılara açıklama satırı eklememiz için class,metot,property vs gibi yapıların üstüne üç slash işareti ile açıklama satırı ekleyebiliriz
#region This Keywordü
//Sınıfın nesnesini temsil eder
//this keywordü ilgili class yapılanmasının o anki nesnesine karşılık gelir.
//this kullanmak zorunlu değildir.
//THİS KULLANILDIĞI YER : Aynı isimde field ile metot parametrelerini ayırmak için kullanılır!!!!
//Bir constructor'dan başka bir constructer'i çağırmak için kullanılır
#endregion
new MyNesneClass();//Heapte nesne oluşturduk. STACK kısmında oluşturualkacak olan bir değişken ile heapteki nesne referans olarak gösterilebilir. Yani
MyNesneClass myNesne; //Stackte oluşturulmuş olan bir değişken bunu New NyNesneClass(); ile stackteki değişkenin referansını heapteki MyNesneClassı nesnesini işaretlemiş oluruz.
//MyNesneClass myNesne = new();

class MyClass
{
    int yasi; //Field
    string b; //Field
    #region Full Property
    //Property hangi türden bir field'i temsil ediyorsa o türden olmalıdır.
    //Propertyler temsil ettikleri field'ların isimlerinin başharfi büyük olacak şekilde isimlendirilir
    public int Yasi
    {
        get
        {
            //Property üzerinden değer talep edildiğinde bu blok tetiklenir. Yani değer buradan gönderilir.
            return yasi;
        }
        set
        {
            yasi = value;
        }
    }
    #endregion
    #region Prop Property
    //Field'i otomatik olarak tanımlar"adi" fieldini tanımlar. Küçük harfle ve get ve set işlemlerini kendi içinde tanımlar.
    public string Adi { get; set; }
    #region Auto Property
    public string Soyadi { get; set; } = "Gündoğdu";
    #endregion
    #endregion
    #region Ref Readonly Returns
    string no;
    public ref readonly string No => ref no;
    #endregion
    #region Computed(Hesaplanmış) Properties
    int s1 = 5;
    int s2 = 5;
    public int Topla
    {
        get
        {
            return s1 + s2;
        }
    }
    #endregion
    #region Expression-Bodied Property
    //public string Cinsiyet
    //{
    //    get
    //    {
    //        return "Erkek";
    //    }
    //}
    public string Cinsiyet => "Erkek"; //bu şekilde kısa bir tanım ile yapılabilir
    #endregion
    #region Init-Only Properties - Init Accessor

    #endregion
    #region Metot
    public int X()
    {
        return 5;
    }
    public int X(int a, int b)
    {
        return a + b;
    }
    #endregion
    #region Indexer
    public int this[int a]
    {
        get
        {
            return a;
        }
        set
        {
            a = value;
        }
    }
    #endregion
}
class Banka
{
    int bakiye;
    public int Bakiye
    {
        get
        {
            if (bakiye > 0)
                return bakiye * 10 / 100;
            return 5;
        }
        set
        {
            if (value < 10)
                bakiye = value;
            else
                bakiye = value * 95 / 100;
        }
    }
}
/// <summary>
/// Bu bir örnek class'tır.
/// </summary>
class MyClass2
{
    int a;
    /// <summary>
    /// Bu bir prop property'dir
    /// </summary>
    public int MyProperty { get; set; }
    /// <summary>
    /// Bu bir örnek metottur.
    /// </summary>
    public void X()
    {

    }
    /// <summary>
    /// Bu bir parametre alan bir metot overloadıdır.
    /// </summary>
    /// <param name="a">a parametresi</param>
    public void X(int a) { }
    public int this[int a]
    {
        get { return a; }
    }
    public class MyClass3
    {

    }
}
class MyClass4
{
    int a;
    public void X()
    {
        //this.a   this keywordünü kullandığımızda field olan a'dır.
    }
}
class MyNesneClass
{
    public int a { get; set; }
    public void X()
    {

    }
}