using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MathFunctionsTest
{
    [Test]
    public void MathAddValidTest()
    {
        int result = MathFunctions.Add(1, 1);
        Assert.AreEqual(2, result);
    }

    [Test]
    public void MathDivideInvalidTest()
    {
        try {
        int result = MathFunctions.Divide(1, 0);
        } catch (System.DivideByZeroException e) {
            Assert.Pass();
        }
    }

}
