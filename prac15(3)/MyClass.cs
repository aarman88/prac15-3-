using System;
using System.Reflection;

public class MyClass
{
    private int privateField;

    public MyClass()
    {
    }

    public MyClass(int value)
    {
        privateField = value;
    }

    public int PublicProperty { get; set; }

    private void PrivateMethod()
    {
        Console.WriteLine("Private method called.");
    }

    public void PublicMethod()
    {
        Console.WriteLine("Public method called.");
    }
}