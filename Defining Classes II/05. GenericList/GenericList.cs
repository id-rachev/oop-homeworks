using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GenericList<T>
{
    private T[] colection;
    private int count = 0;

    public GenericList(int capacity)
    {
        this.colection = new T[capacity];
    }

    public int Count
    {
        get { return this.count; }
    }

    public void Add(T newElement)
    {
        if (count >= colection.Length)
        {
            throw new IndexOutOfRangeException(String.Format(
                "The list capacity of {0} was exceeded.", colection.Length));
        }
        this.colection[count] = newElement;
        count++;
    }

    public T this[int index]
    {
        get
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            return this.colection[index];
        }
        set
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            this.colection[index] = value;
        }
    }

    public void RemoveByIndex(int indexToRemove)
    {
        if ((indexToRemove < 0) || (indexToRemove >= colection.Length))
        {
            throw new IndexOutOfRangeException(String.Format(
                "Invalid index: {0}.", indexToRemove));
        }

        T[] newColection = new T[colection.Length - 1];
        for (int index = 0, newIndex = 0; index < colection.Length; index++, newIndex++)
        {
            if (index == indexToRemove)
            {
                newIndex--;
                continue;
            }
            newColection[newIndex] = colection[index];
        }
        this.colection = newColection;
        this.count--;
    }

    public void InsertAtIndex(T newElement, int insertIndex)
    {
        if ((insertIndex < 0) || (insertIndex > colection.Length))
        {
            throw new IndexOutOfRangeException(String.Format(
                "Invalid index: {0}.", insertIndex));
        }

        T[] newColection = new T[colection.Length + 1];
        for (int index = 0, newIndex = 0; newIndex < newColection.Length; index++, newIndex++)
        {
            if (newIndex == insertIndex)
            {
                newColection[newIndex] = newElement;
                index--;
                continue;
            }
            newColection[newIndex] = colection[index];
        }
        this.colection = newColection;
        this.count++;
    }

    public void Clear()
    {
        this.colection = new T[0];
        this.count = 0;
    }

    public int? FindElement(T element)
    {
        int? index = new int();

        for (int i = 0; i < colection.Length; i++)
        {
            if (colection[i].Equals(element))
            {
                index = i;
            }
        }
        return index;
    }

    public override string ToString()
    {
        string colectionToString = "";
        for (int index = 0; index < colection.Length; index++)
        {
            if (index != colection.Length - 1)
            {
                colectionToString += colection[index] + ", ";
            }
            else
            {
                colectionToString += colection[index];
            }
        }
        return colectionToString;
    }
}