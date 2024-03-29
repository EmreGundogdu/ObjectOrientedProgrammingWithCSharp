﻿#region Field
//Field : Nesne içerisinde değer tutmamızı sağlayan alanlardır.
//Class : içerisinde tanımlanan fieldlara kendi türün default değerler verilir. Metot içerisinde tanımlanan değişkenlere default değer verilmez.
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
MyReferanceClass myReferance = new MyReferanceClass(); //Referanslı nesne
myReferance.MyProperty = 10; //Heapteki MyReferanceClass nesnesinin myproperty alanı 10 olmuş oldu
new MyReferanceClass(); //Referanssız Nesne
                        //Referanssız Nesne : Eğer ki bir nesne referanssızsa bunu oluşturabilmekteyiz... lakin bu nesne sistemde/memory'de lüzumsuz yer kaplayacagından dolayı belli bir süre sonra Garbage Collector dediğimiz çöp toplayıcısı tarafından temizlenecektir. Garbage Collector : Heap'te referanssız olan nesneleri imha etmekten/temizlemekten sorumlu bir yapılanmadır.

//Oluşturduğumuz yapılara açıklama satırı eklememiz için class,metot,property vs gibi yapıların üstüne üç slash işareti ile açıklama satırı ekleyebiliriz
#region Shallow Copy
//Referans türlü değişkenlerin/değerlerin default davranışı shallow copy'dir
//Bir nesne stack'te birden fazla referans ile işaretlenirse buna SHALLOW COPY DENİR
//YANİ : HEAPTE NESNE TEK LAKİN STACKTE İŞARETLEYEN REFERANS SAYISI BİRDEN FAZLA İSE BUNA SHALLOW COPY DENİR.
#region Örnek 1
MyShallowClass shallowClass = new MyShallowClass();
MyShallowClass shallowClass1 = shallowClass;
MyShallowClass shallowClass2 = shallowClass;
#endregion
#region Örnek 2
MyShallowClass m1 = null; //4)m1'in referansı da heapteki nesne oldu
MyShallowClass m2 = new MyShallowClass(); //1)Heapteki nesneyi referans eder
MyShallowClass m3 = m2; //2)m2'de nesneyi referans ettikten sonra aynı nesneyi m3 ile referans ettik
m1 = m3; //3)m3'ün referans ettiği bir nesne vardı heapte bunu m1'e referans ediyoruz işaretliyoruz yani m1'in referansı da heapteki myshallowcase nesnesi oldu
#endregion
#region Örnek 3
MyShallowClass m4 = new MyShallowClass(); //1) m4 referansımız var heapte bir nesneyi işaretliyor var
MyShallowClass m5 = new MyShallowClass(); //2) m5 referansı var heapte bir tane daha nesneyi işaretliyor
MyShallowClass m6 = m4; //3) m4 referansının heapteki nesnesini işaretliyor
m4 = m5; //m4 referansı m5 referansının işaretlediği nesneyi işaretlicektir. yani m4ün nesnesi değişti
m5 = m4; //m5 referansı kendi nesnesini işaret ettiği için m4'te zaten m5'in referansını işaretliyodu.bozulmadı
m4 = m4; //m4 referansı neyi işaret ediyorsa onu tekrar işaretlicek
#endregion
#endregion
#region Deep Copy
//int a = 5;
//int b = a;  //a'nın değeri kopyalandı ve b'ye atanır. KISACA DEEP COPY BU KADAR. Bunlar birbirlerinden farklı çalışırlar. a'yı 5 ile çarptığımız zaman 25 gelir ama b'nin değeri etkilenmez

//Değer türlü değişkenlerde stackte bulunan değişkenlerin heapte bulunan bir nesneyi işaretlemesidir.
//Değer türlü değişkenlerde default davranış deep copydir.
#endregion
#region Nesnelerde Deep Copy
MyDeepClass myDeepClass = new MyDeepClass();
MyDeepClass myDeepClass1 = myDeepClass.Clone(); //Memberwise fonk ile bir nesne işaretlenirse o zaman nesnelerde deep copy olmuş olur
#endregion
#region This Keywordü
//Sınıfın nesnesini temsil eder
//this keywordü ilgili class yapılanmasının o anki nesnesine karşılık gelir.
//this kullanmak zorunlu değildir.
//THİS KULLANILDIĞI YER : Aynı isimde field ile metot parametrelerini ayırmak için kullanılır!!!!
//Bir constructor'dan başka bir constructer'i çağırmak için kullanılır
#endregion
#region Object Initializer İle Nesne Oluşturma Esnasında Propertylere İlk Değer Atama
MyReferanceClass myReferance2 = new MyReferanceClass();//Bu yapılanmada nesneyi oluşturduk ama propertylerine değer vermediğimizden dolayı classın propertyleri field alanları default değerleri alıcaktır.
MyReferanceClass myReferance1 = new MyReferanceClass()
{
    MyProperty = 5,
    MyProperty2 = 10,
    MyProperty3 = 15,
};//Bu yapılanmada Nesneyi oluştururken değerleri verdik

#region Referanssız Nesneye Değer atama
new MyReferanceClass()
{
    MyProperty = 20,
    MyProperty2 = 20,
    MyProperty3 = 20,
};
#endregion
#endregion
new MyNesneClass();//Heapte nesne oluşturduk. STACK kısmında oluşturualkacak olan bir değişken ile heapteki nesne referans olarak gösterilebilir. Yani
MyNesneClass myNesne; //Stackte oluşturulmuş olan bir değişken bunu New NyNesneClass(); ile stackteki değişkenin referansını heapteki MyNesneClassı nesnesini işaretlemiş oluruz.
                      //MyNesneClass myNesne = new();
new MyConstructorClass(5);
MyConstructorClass myConstructorClass = new(15);
MyConstructorClass myConstructorClass2 = new("Emre");
MyConstructorClass myConstructorClass3 = new("Emre", 21);
MyPrivateConstructorClass myPrivate = new MyPrivateConstructorClass();
new MyThisConstructorClass(5, 6); //birinci constructor sonra ikinci constructor çalışır.

void X()
{
    MyDestructorClass myDestructorClass = new MyDestructorClass();
}

#region Encapsulation Examples
MyEncapsulationClass myEncapsulation = new MyEncapsulationClass();
myEncapsulation.ASet(15);
Console.WriteLine(myEncapsulation.AGet());

myEncapsulation.b = 1234;
Console.WriteLine(myEncapsulation.b);
#endregion
#region Init-Only Properties
//Init-only Properties özelliğine 'init' keywordü eşlik etmektedir.
MyRecordClass myRecordClass = new MyRecordClass()
{
    A = 10,
    IntOzellik = 5,
    StringOzellik = "Emre"
};
Console.WriteLine(myRecordClass.IntOzellik); //Readonly'dir ama yazılabilir değildir. Anca object initializer'de değer atanır.
Console.WriteLine(myRecordClass.StringOzellik);
#endregion
#region Record
MyRecord recordClass = new MyRecord()
{
    MyProperty = 5,
    MyProperty2 = 10
};
//Field alanalarına object initializer yapılanması ile değer veriyoruz.
MyRecord recordClass2 = recordClass with { MyProperty2 = 15 };
#endregion
#region Constructor
//T t = new T(); //Buradaki parantezler constructor metodunun parantezleridir. Nesneye dair konfigurasyon yapmamızı sağlayan ve nesne üretilirken ilk tetiklenen fonksiyondur.
//Constructor, nesne oluşturma sürecinde tetiklenmek zorundadır.
//Constructor Davranış Modeli : Bir classtan nesne üretirken o class'ın field alanlarına nesneyi oluştururken değer atamak istiyorsak Constructor metod ile bunu yaparız
//Her nesnenin içerisinde default bir constructor vardır. Yani class içerisinde constructorunu oluşturmasak ve nesneyi constructorsuz bir class'tan oluştursak, nesne oluştururken default bir constructor oluşur
//Constructor'ın erişim belirleyicisini private yaparken nesne üretimini engellemiş oluruz.
#endregion
#region Destructor/Finalizer 
//Bir class'tan üretilmiş olan nesne imha edilirken otomatik çağırılan metottur.
//Sadece class'ta ve bir kere tanımlanabilir ve parametre alamayan bir fonksiyondur.
#endregion
#region Destructor 1. Örnek
X();
GC.Collect(); //garbage collecturu devreye soktuk.
Console.ReadLine();
#endregion
#region Destructor 2. Örnek
int sayi = 100;
while (sayi >= 1)
    new MyMyDestructorClass2(sayi--);
GC.Collect();
Console.ReadLine();
#endregion
#region Deconstructor
//Bir sınıf içerisinde "Deconstruct" ismiyle tanımlanan metot, compiler tarafından özel olarak algılanmakta ve sınıfın nesnesi üzerinden geriye hızlıca Tuple bir değer dödnürmemizi sağlar
Person person = new Person()
{
    Name = "Emre",
    Age = 21
};
var (x, y) = person;
#endregion
#region Static Constructor
//Bir sınıftan ilk nesne üretilirken ilk tetiklenecek olan metottur.
//Üretilen ilk nesnenin dışında bir daha tetiklenmez
new MyStaticConstructorClass();

#endregion
#region Singleton Design Pattern
//Bir sınıftan uygulama bazında sade ve sadece tek bir nesne oluşturulmasını istiyorsan kullanabileceğin bir design pattern.
var database1 = Datebase.GetInstance;
var database2 = Datebase.GetInstance;
var database3 = Datebase.GetInstance;
database1.ConnectionString = "sdasdasdasdas";
//1. Nesne'de yaptığım değişiklik diğer nesneleri de etkileyeceği için yani Single Design ile static yapılanmadan dolayı bir nesne üretileceği için database 1'de yapılan değişiklik diğer bütün değişkenlerde de etki gösterdi
#endregion
#region Positional Record
MyRecordClass2 myRecordClass2 = new MyRecordClass2("Emre", "DASDASDSA");
var (n, s) = myRecordClass2; //MyRecordClass2'de parametreli verdik sonra burada onlar TUPLE yöntemi ile 'n' ve 's' değişkenlerine atadık.

#endregion
//CLASSLAR 
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
class MyReferanceClass
{
    public int MyProperty { get; set; }
    public int MyProperty2 { get; set; }
    public int MyProperty3 { get; set; }
}
class MyShallowClass
{

}
class MyDeepClass
{
    public MyDeepClass Clone()
    {
        //MemberwiseClone : Bir sınıf içerisinde o sınıftan üretilmiş olan o anki nesneyi clonelamamızı sağlayan bir fonksiyondur.
        return (MyDeepClass)this.MemberwiseClone();
    }
}
class MyEncapsulationClass
{
    #region Eskiden Yapılan Encapsulation
    //Eski yöntem ile encapsulation
    int a;
    public int AGet()// a filedini dışarıya verdik
    {
        return this.a;
    }
    public void ASet(int value) //Dışarıdan gelen value değerini a fieldnin değerine atadık
    {
        this.a = value;
    }
    #endregion
    #region Yeni Yöntem İle Encapsulation
    public int b;
    public int MyProperty
    {
        get
        {
            return b;
        }
        set
        {
            b = value;
        }
    } //Full Property
    #endregion
}
class MyRecordClass
{
    //init keywordünü kullandığımız zaman propertylerin hem readonly hemde değer atamak istediğimiz zaman object initializer yaparken değer atamamızı sağlar. Object initializer dışında nesne tanımlarken propertylere değer atamak istersek Init-only buna izin vermiyecektir. Sadece ve sadece object initializer zamanında 'init' keywordü kullanılan propertylere değer atayabiliriz. 'init' keywordü get keywordü olmaksızın kullanılamaz ve set bloğunda kullanılamaz yani set olmucak.
    readonly int a;
    public int A
    {
        get
        {
            return a;
        }
        init //Readonly bir field'a değer atamak için de init keywordü kullanılır.
        {
            a = value;
        }
    }
    public int IntOzellik { get; init; } = 10;
    public string StringOzellik { get; init; } = "Emre";
}
//recordlar bir classtır
record MyRecord
{
    public int MyProperty { get; init; }
    public int MyProperty2 { get; init; }
    public void X()
    {

    }
    public MyRecord()
    {

    }
    ~MyRecord()
    {

    }
    static MyRecord()
    {

    }
}
class MyConstructorClass
{
    public MyConstructorClass(int a)
    {
        Console.WriteLine("Bir adet myconstructor nesnesi oluşturuldu." + a);
    }
    public MyConstructorClass()
    {

    }
    public MyConstructorClass(string a)
    {

    }
    public MyConstructorClass(string a, int b)
    {

    }
}
class MyPrivateConstructorClass
{
    MyPrivateConstructorClass()
    {

    }
    void X()
    {
        new MyPrivateConstructorClass();
    }
}
class MyThisConstructorClass
{
    public MyThisConstructorClass()//3) 2. constructor burayı çalıştırır.
    {
        Console.WriteLine("1. Constructor");
    }
    public MyThisConstructorClass(int a) : this() //2)parametre almayan constructoru tetikler
    {
        Console.WriteLine($"2. Constructor : a = {a}");
    }
    public MyThisConstructorClass(int a, int b) : this(a)//1)int a parametresi alan constructor tetiklenicek
    {
        Console.WriteLine($"3. Constructor : a = {a} & b = {b}");
    }
}
record MyRecordConstructorClass
{
    public MyRecordConstructorClass()
    {
        Console.WriteLine("1. Constructor");
    }
    public MyRecordConstructorClass(int a) : this()
    {
        Console.WriteLine($"2. Constructor a: {a}");
    }
}
class MyDestructorClass
{
    public MyDestructorClass()
    {
        Console.WriteLine("Nesne üretildi");
    }
    ~MyDestructorClass()
    {
        Console.WriteLine("Nesne imha ediliyor...");
    }
}
class MyMyDestructorClass2
{
    int no;
    public MyMyDestructorClass2(int no)
    {
        this.no = no; ;
        Console.WriteLine($"{no}. nesne oluşturuldu");
    }
    ~MyMyDestructorClass2()//Destructor metod
    {
        Console.WriteLine($"{no}. nesne imha edilmiştir.");
    }
}
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public void Deconstruct(out string name, out int age)//out keywordü ile bu parametreleri dıştaki değerlere atıyoruz. Yukarıda örneği var.
    {
        name = Name;
        age = Age;
    }
}
class MyStaticConstructorClass
{
    public MyStaticConstructorClass()
    {
        Console.WriteLine("MyStaticConstructorClass constructoru tetiklendi");
    }
    //Static constructor'da geri dönüş değeri ve erişim belirleyicisi bildirilmez... Overloading yapılmaz. bir sınıfın içierisnde sadece bir tane tanımlanabilir. Yani parametre almaz
    static MyStaticConstructorClass()
    {
        Console.WriteLine("MyStaticConstructorClass static constructoru tetiklendi");
        //Static constructor'ın tetiklenebilmesi için illa ilk nesne üretimi yapılmasına gerek yoktur. İlgili sınıf içerisinde herhangi bir static yapılanmada tetiklenmesi static const. tetiklenmesini sağlayacaktır.
    }
}
class Datebase
{
    //Singletion Design'da bir tane nesne üretilmesi için yani bunun sağlanması için constructorun private olması gerekir.
    Datebase()
    {

    }
    public string ConnectionString { get; set; }
    static Datebase datebase;
    static public Datebase GetInstance
    {
        get
        {
            return datebase;
        }
    }
    static Datebase()
    {
        datebase = new Datebase();
    }
}
record MyRecordClass2(string Name, string Username)//Nesne oluştururken bu constructorun çalışması zorunlu
{
    public MyRecordClass2() : this("emre", "derder")
    {

    }
    public MyRecordClass2(string name) : this()
    {

    }
}