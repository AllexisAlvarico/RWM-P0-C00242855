using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reverse
{
    // Start is called before the first frame update
    //public static int reverseFliter(int[] index)
    //{
    //    return index.Length;
    //}

    // Update is called once per frame
    public static int[] reverses(int[] xs)
    {
        int newpos = 0;
        int[] result= new int[xs.Length];
        //int lastIndex = xs.Length;
        for(int i = xs.Length -1; i >= 0 ; i--)
        {
            result[newpos] = xs[i];
            newpos++;
        }
        return result;
    }
}
