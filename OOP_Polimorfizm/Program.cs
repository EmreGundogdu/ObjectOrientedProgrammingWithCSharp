﻿//Bir nesnenin, birden fazla referansla işaretlenmesi; o nesnenin, birden fazla türün davranışlarını gösterebilmesini sağlar
MyClass2 myClass = new MyClass();
class MyClass : MyClass2
{

}
class MyClass2
{

}