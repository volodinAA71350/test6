using System.Collections.Generic;

namespace PhysicValuesLib.Values;

public class Joule : IValue
{
    private double Value { get; set; }
    private string? From { get; set; }
    private string? To { get; set; }

    private string _valueName = "Джоуль";

    private List<string> _measureList = new List<string>()
    {
        "Джоуль",
        "Кило Джоуль",
        "Мега Джоуль",
        "Мили Джоуль"
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
            case "Джоуль":
                break;
            case "Кило Джоуль":
                Value /= 1000;
                break;
            case "Мега Джоуль":
                Value /= 1000000;
                break;
            case "Мили Джоуль":
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
            case "Джоуль":
                break;
            case "Кило Джоуль":
                Value *= 1000;
                break;
            case "Мега Джоуль":
                Value *= 1000000;
                break;
            case "Мили Джоуль":
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