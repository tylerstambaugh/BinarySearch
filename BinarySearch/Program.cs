using System;
using System.Collections.Generic;
using System.Linq;


public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int keyPosition = -1;
        bool keepSearching = true;
        int[] currentArray = input;
        int currentArrayMid;
        int addr = 0;
        if (currentArray.Length == 0)
            keepSearching = false;
        while (keepSearching)
        {
            if (currentArray.Length % 2 == 0)
            {
                currentArrayMid = currentArray.Length / 2 + 1;
            }
            else
            {
                currentArrayMid = (currentArray.Length / 2);
            }
            if (currentArray[currentArrayMid] == value)
            {
                keyPosition = currentArrayMid + addr;
                keepSearching = false;
            }
            else if (currentArray.Length == 1 && currentArray[0] != value)
            {
                keepSearching = false;

            }
            else if (currentArray[currentArrayMid] > value)
            {
                currentArray = currentArray.Take(currentArrayMid).ToArray();
                keepSearching = true;
            }
            else if (currentArray[currentArrayMid] < value)
            {
                currentArray = currentArray.Skip(currentArrayMid).Take(currentArray.Length - (currentArrayMid - 1)).ToArray();
                addr += currentArrayMid;
                keepSearching = true;
            }
        }
        return keyPosition;
    }

}