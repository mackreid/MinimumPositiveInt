using System;
using System.Collections.Generic;

public class MinPositiveInt {
    // Returns the min positive int from an array
    public static int Solve(int[] A) {
        // Create an empty list of int
        List<int> listOfPos = new List<int>();
        // Loop through the array and add all positive ints to list
        foreach(int a in A) {
            if(a > 0) {
                listOfPos.Add(a);
            }
        }
        // Turn the list into an array and sort 
        int[] positiveArray = listOfPos.ToArray();
        Array.Sort(positiveArray);

        // Set the smallest possible int 
        int smallest = 1;
        // Loop through the positive array
        for(int i = 0; i < positiveArray.Length; i++) {
            // If the int equals the the current smallest, add 1
            if(positiveArray[i] == smallest) smallest++;
            // If the int is greater than the smallest then just return smallest
            else if(positiveArray[i] > smallest) return smallest;
        }
        // Return smallest 
        return smallest;
    }
}