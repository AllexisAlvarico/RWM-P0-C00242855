using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ReverseTest
    {
    // A Test behaves as an ordinary method
    [Test]
    public void ReverseTestSimplePasses()
    {
        int[] input = {4,3,10,1,127};
        int[] output = Reverse.reverses(input);
        int[] expected = {127,1,10,3,4};

        CollectionAssert.AreEqual(expected,output);
        // Use the Assert class to test conditions
    }
    }
}

