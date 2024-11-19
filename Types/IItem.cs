namespace WpfAppCalculate.Types;

/// <summary>
/// CalcType defines types of buttons from calc
/// </summary>
public enum CalcType
{
    None,
    Value,
    Func
}



/// <summary>
/// 
/// </summary>
public interface IItem
{
    public string Name { get; }
    public CalcType CalcType { get; }
}