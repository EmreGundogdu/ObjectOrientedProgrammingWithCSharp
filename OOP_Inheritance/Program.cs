Muhasabeci muhasabeci = new();
Mudur Mudur = new();
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