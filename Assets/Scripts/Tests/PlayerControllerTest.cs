using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerControllerTest
{
    [Test]
    public void MathAddValidTest()
    {
        // Arrange
        PlayerController script = new GameObject().AddComponent<PlayerController>();

        // Act
        int result = script.ChangeLife(-10);

        // Assert
        Assert.AreEqual(90, result);
    }

}
