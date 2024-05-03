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

    //Visualization + implementation of the linear search w/o list slicing
    public void PerformSearch()
    {
        Console.Clear();
        foreach (var item in _lst)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < _lst.Count(); i++)
        {
            for (int a = 0; a < i; a++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(_lst[a] + " ");
            }
            Console.ResetColor();

            if (_lst[i] == _target)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(_lst[i] + " ");
                Console.ResetColor();

                for (int y = i + 1; y < _lst.Count(); y++)
                {
                    Console.Write(_lst[y] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("ELEMENT FOUND!!");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(_lst[i] + " ");
                Console.ResetColor();
                for (int y = i + 1; y < _lst.Count(); y++)
                {
                    Console.Write(_lst[y] + " ");
                }
                Console.WriteLine();
                if (i == _lst.Count() - 1)
                {
                    Console.WriteLine("ELEMENT NOT FOUND!!");
                }
            }
        }
    }
}