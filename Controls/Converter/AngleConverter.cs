using System.Collections;
namespace ModernUiDesign 
{
    public class AngleConverter : IConverter
    {

        decimal FromUnitValue { get; private set;}
        string FromUnitName { get; private set; }
        string ToUnitName { get; private set;}
        string ResultString { get; private set;}

public AngleConverter(decimal fromUnitValue, string fromUnitName, string toUnitName)
{
            FromUnitValue = fromUnitValue;
            FromUnitName = fromUnitName;
            ToUnitName = toUnitName;
            ResultString=$"{FromUnitName}-{ToUnitName}";
 }

public enum AngleUnit
{
Degrees, Radians, Gradians
}
        string  GetUnswer()
        {
        Hashtable angleTable=new Hashtable();
        //Degrees to another units
        angleTable.Add($"{AngleUnit.Degrees}-{AngleUnit.Gradians}", (FromUnitValue * Math(Pi)/180)m);
        
        if(angleTable.ContainsKey(ResultString))
        {
            return angleTable[ResultString].ToString;
        }

        else  return "0.error";
        }
    }

}