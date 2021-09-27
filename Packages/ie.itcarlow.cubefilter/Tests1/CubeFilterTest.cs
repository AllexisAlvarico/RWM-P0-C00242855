using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


namespace Tests1
{
    public class CubeFilterTest
    {
    // A Test behaves as an ordinary method
    [Test]
    public void CubeFilterTestSimplePasses()
    {
        int[] input = {1,3,5,7,9,999};
        int[] output = CubeFilter.cubes(input);
        int[] expected = {1,27,125,343,729,997002999};

        CollectionAssert.AreEqual(expected,output);
        // Use the Assert class to test conditions
    }
    }
}

