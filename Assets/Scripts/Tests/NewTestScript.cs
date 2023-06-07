using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    // A Test behaves as an ordinary method
    [Test]
    public void NewTestScriptSimplePasses()
    {
        // Arrange
        SampleScript script = new GameObject().AddComponent<SampleScript>();
        int initialScore = script.Score;
        int amount = 10;

        // Act
        script.IncreaseScore(amount);

        // Assert
        int expectedScore = initialScore + amount;
        Assert.AreEqual(expectedScore, script.Score);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}