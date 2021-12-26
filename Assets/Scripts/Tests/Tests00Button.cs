using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Tests00Button
{
    // A Test behaves as an ordinary method
    [Test]
    public void Test01ButtonClick()
    {
        Assert.Fail();
    }

    [Test]
    public void Test02ButtonNotClick()
    {
        Assert.Pass();
    }

}
