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
    public int Adi { get; set; } 
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