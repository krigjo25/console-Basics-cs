using System;
using console_Basics_cs.lib;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace console_Basics_cs.Tests.lib;

[TestClass]
[TestSubject(typeof(Kalkulator))]
public class KalkulatorTest
{
    Kalkulator _calc = new Kalkulator();
    
    [
        TestCase(5,5),  TestCase(10,10)
    ]
    public void PlussTests(int a, int b)
    {
        Assert.AreEqual(_calc.Add(a, b), a + b);
        
    }
    
    [
        TestCase(5,5),  TestCase(10,10),
    ]
    public void SubstractTests(int a, int b)
    {
        Assert.AreEqual(_calc.Substract(a, b), a - b);
    }
    
    [
        TestCase(5,5),  TestCase(10,10),
    ]
    public void MultiplyTests(int a, int b)
    {
        Assert.AreEqual(_calc.Multiply(a, b), a * b);   
    }

    [
        TestCase(5,5),  TestCase(10,10),
    ]
    public void DivideTests(int a, int b)
    {
        Assert.AreEqual(_calc.Divide(a, b), a / b);   
    }

    [
        TestCase(4,0)
    ]
    public void DivideRaisesTests(int a, int b)
    {
        Assert.ThrowsException<DivideByZeroException>(() => _calc.Modulus(a,b));
    }
    
    [
        TestCase(4,1),  TestCase(10,10)
    ]
    public void ModulusTests(int a, int b)
    {
        Assert.AreEqual(_calc.Modulus(a, b), a % b);
    }
    
    [
        TestCase(4,0)
    ]
    public void ModuloRaisesTests(int a, int b)
    {
        Assert.ThrowsException<DivideByZeroException>(() => _calc.Modulus(a,b));
    }

}