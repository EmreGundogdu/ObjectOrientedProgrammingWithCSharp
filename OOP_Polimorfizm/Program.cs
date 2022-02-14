//Bir nesnenin, birden fazla referansla işaretlenmesi; o nesnenin, birden fazla türün davranışlarını gösterebilmesini sağlar
MyClass2 myClass = new MyClass();
A a = new B();
class MyClass : MyClass2
{

}
class MyClass2
{

}

class A
{

}
class B : A
{

}