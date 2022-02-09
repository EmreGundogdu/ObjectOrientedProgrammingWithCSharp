Muhasabeci muhasabeci = new();
Mudur Mudur = new();
//Bir class'ın sadece bir tane Base Class'ı olur
//Bir sınıftan nesne üretimi yapılırken kalıtım aldığı üst sınıflar varsa eğer önce o sınıflardan SIRAYLA nesne üretilir. Örnek : C classı B classının alt classı olsun ve B class'ı da A class'ının alt classı olsun. C classından nesne üretmek istediğimiz zaman Önce A, sonra B ve sonra da C classlarından sıraysıyla nesneler üretilecektir.
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