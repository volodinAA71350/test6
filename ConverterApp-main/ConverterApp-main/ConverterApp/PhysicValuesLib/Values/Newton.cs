using System.Collections.Generic;

namespace PhysicValuesLib.Values;

public class Newton : IValue
{
    private double Value { get; set; }
    private string? From { get; set; }
    private string? To { get; set; }

    private string _valueName = "Ньютон";

    private List<string> _measureList = new List<string>()
    {
        "Ньютон",
        "Кило Ньютон",
        "Мега Ньютон",
        "Мили Ньютон"
    };

    /// <summary>
    /// Метод возвращает конвертированное значение
    /// </summary>
    /// <returns></returns>
    public double GetConvertedValue(double value, string from, string to)
    {
        Value = value;
        From = from;
        To = to;

        ToSi();
        ToRequired();
        return Value;
    }

    /// <summary>
    /// Метод возвращает список единиц измерения
    /// </summary>
    /// <returns></returns>
    public List<string> GetMeasureList()
    {
        return _measureList;
    }

    /// <summary>
    /// Метод конвертирует в нужные единицы измерения
    /// </summary>
    public void ToRequired()
    {
        switch (To)
        {
            case "Ньютон":
                break;
            case "Кило Ньютон":
                Value /= 1000;
                break;
            case "Мега Ньютон":
                Value /= 1000000;
                break;
            case "Мили Ньютон":
                Value *= 1000;
                break;
        }
    }

    /// <summary>
    /// Метод переводит в систему СИ
    /// </summary>
    public void ToSi()
    {
        switch (From)
        {
            case "Ньютон":
                break;
            case "Кило Ньютон":
                Value *= 1000;
                break;
            case "Мега Ньютон":
                Value *= 1000000;
                break;
            case "Мили Ньютон":
                Value /= 1000;
                break;
        }
    }

    public string GetValueName()
    {
        return _valueName;
    }

    public Dictionary<string, double> ConvertationCoefficient()
    {
        throw new NotImplementedException();
    }
}