using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzzFilter
{
    public static int replace(int x)
    {
        if (x % 5 == 0 && x % 3 == 0)
        {
            return 0;
        }
        if (x % 3 == 0)
        {
            return 3;
        }
        if (x % 5 == 0)
        {
            return 5;
        }
        return x;
    }

    public static int[] fizzBuzzReplace(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = replace(xs[i]);
        }
        return result;
    }

}
