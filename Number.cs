using System;

public class Number
{
    private int _value;

    public int Value
    {
        get { return _value; }  // Getter
        set { _value = value; } // Setter
    }

    public Number(int value)
    {
        Value = value;
    }
}