//class to represent linear search visualization in console
using System;
using System.Collections.Generic;

class LinearSearch
{
    private int _target;
    private List<int> _lst;

    public int Target
    {
        set { _target = value; }
    }

    public List<int> ListOfNumbers
    {
        set { _lst = value; }
    }

    public LinearSearch(int target, List<int> list)
    {
        Target = target;
        ListOfNumbers = list;
    }

    //Visualization + implementation of the linear search
    public void PerformSearch()
    {
        Console.Clear();

    }
}