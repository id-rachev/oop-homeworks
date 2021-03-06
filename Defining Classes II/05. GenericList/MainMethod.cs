﻿using System;
using System.Collections.Generic;
using System.Linq;

// Write a generic class GenericList<T> that keeps a list of elements
// of some parametric type T. Keep the elements of the list in
// an array with fixed capacity which is given as parameter in
// the class constructor. Implement methods for adding element,
// accessing element by index, removing element by index, inserting
// element at given position, clearing the list, finding element
// by its value and ToString(). Check all input parameters to avoid
// accessing elements at invalid positions.

class MainMethod
{
    static void Main()
    {
        GenericList<int> myIntList = new GenericList<int>(3);


        Console.WriteLine(myIntList.Count);

        myIntList.Add(101);
        myIntList.Add(102);
        myIntList.Add(103);


        myIntList[2] = 3;
        Console.WriteLine(myIntList[2]);
        Console.WriteLine();

        myIntList.InsertAtIndex(4, 0);
        Console.WriteLine(myIntList.Count);
        Console.WriteLine(myIntList);

        Console.WriteLine(myIntList.FindElement(4));
    }
}
