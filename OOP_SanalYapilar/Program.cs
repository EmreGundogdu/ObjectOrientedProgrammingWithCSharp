#region Virtual-Override Örnek 1 - EK 
Kalem kalem = new();
kalem.Bilgi();
class Obje
{
    public virtual void Bilgi()
    {
        Console.WriteLine("Ben bir objeyim");
    }
}
class Kalem : Obje
{
    public override void Bilgi()
    {
        Console.WriteLine("Ben bir Kalemim");
    }
}
#endregion
#region Virtual-Override Örnek 2

class Memeli
{
    public virtual void Konus()
    {
        Console.WriteLine("Ben konuşmuyorum...");
    }
}
class Maymun : Memeli
{
    public override void Konus()
    {
        Console.WriteLine("Ben maymunum...");
    }
}
class Inek : Memeli
{
    public override void Konus()
    {
        Console.WriteLine("Ben ineğim...");
    }
}
#endregion
#region Virtual-Override Örnek 3
class AlanOrnek
{
    public void FormulHesaplamalari()
    {
        Ucgen ucgen = new Ucgen(3, 4);
        Dortgern dortgen = new Dortgern(4, 5);
    }
}
class Sekil
{
    public int _boy;
    public int _en;
    public Sekil(int boy, int en)
    {
        _boy = boy;
        _en = en;
    }
    public virtual int AlanHesapla()
    {
        return 0;
    }
}
class Ucgen : Sekil
{
    public Ucgen(int boy, int en) : base(boy, en)
    {

    }
    public override int AlanHesapla()
    {
        return _boy * _en / 2;
    }
}
class Dortgern : Sekil
{
    public Dortgern(int boy, int en) : base(boy, en)
    {

    }
    public override int AlanHesapla()
    {
        return _boy * _en;
    }
}
class Dikdortgen : Sekil
{
    public Dikdortgen(int boy, int en) : base(boy, en)
    {

    }
    public override int AlanHesapla()
    {
        return _boy * _en;
    }
}
#endregion