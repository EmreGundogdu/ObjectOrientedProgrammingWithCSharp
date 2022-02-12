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