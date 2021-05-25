using system;
Class MyType
{
    public static implicit operator int(MyType m)
{
    //code to convert from MyType to int
}
}
MyType X;
//implicit call MyType's MyType-to-int
int i = X;
using System;

