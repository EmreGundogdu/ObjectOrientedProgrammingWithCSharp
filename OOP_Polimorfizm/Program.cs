//Bir nesnenin, birden fazla referansla işaretlenmesi; o nesnenin, birden fazla türün davranışlarını gösterebilmesini sağlar
MyClass2 myClass = new MyClass();
A a = new B();
B b = new B();
C c = new B();
C c2 = new C();
Insan insan = new Erkek();
Insan insan2 = new Kadin();
class MyClass : MyClass2
{

}
class MyClass2
{

}

class A : C
{
    public void X()
    {

    }
}
class B : A
{
    public void Y()
    {

    }
}
class C
{
    public void Z()
    {

    }
}
class Insan
{

}
class Erkek : Insan
{

}
class Kadin : Insan
{

}