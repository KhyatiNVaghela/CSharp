﻿/*internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
*/
/*
 *  C# Program to Demonstrate New modifier
 */
using System;
 
class TEST
{
    public void func()
    {
        Console.WriteLine("TEST.func");
    }
}
 
class TEST1 : TEST
{
    public new void func()
    {
        Console.WriteLine("TEST1.func");
    }
}
 
class Program
{
    private static void Main()
    {
        TEST ref1 = new TEST(); 
        TEST ref2 = new TEST1();
        TEST1 ref3 = new TEST1();
 
        ref1.func();
        ref2.func();
        ref3.func();
        Console.Read();
    }
}