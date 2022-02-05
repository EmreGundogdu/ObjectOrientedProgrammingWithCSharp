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