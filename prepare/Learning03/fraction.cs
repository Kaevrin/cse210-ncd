using System.ComponentModel.Design;
using System.Globalization;

public class Fraction {
    private int _top;
    private int _bottom;

    private float _decimal;

//first integer getter/setter
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }

    //second integer getter/setter
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fraction = $"{_top.ToString()}/{_bottom.ToString()}";
        return fraction;
    }
    public double GetDecimal()
    {
        return (double)_top / (double)_bottom;
    }

    //Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
}