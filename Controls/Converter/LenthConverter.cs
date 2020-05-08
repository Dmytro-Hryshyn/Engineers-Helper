using System;
using System.Collections;

namespace ModernUiDesign
{
    public class LenthConverter : IConverter
    {
        public decimal FromUnitValue { get; private set; } = 0;

        public string FromUnitName { get; private set; } = string.Empty;

        public string ToUnitName { get; private set; } = string.Empty;

        public string ResultString { get; private set; }

        public LenthConverter(decimal fromUnitValue, string fromUnitName, string toUnitName)
        {
            FromUnitValue = fromUnitValue;
            FromUnitName = fromUnitName;
            ToUnitName = toUnitName;
            ResultString = $"{fromUnitName}_{toUnitName}";
        }

        public  string GetUnswer()
        {
            Hashtable lenthTable = new Hashtable();

            lenthTable.Add($"{ LenthUnits.Metres }_{ LenthUnits.Centimetres }", FromUnitValue * 1.5m);


            if (lenthTable.ContainsKey(ResultString))
            {
                return lenthTable[ResultString].ToString();
            }



            return "Error..";

        }

        public enum LenthUnits

        {

            Kilometre,
            Metres,
            Centimetres,
            Millimetre,
            Micrometre,
            Nanometre,
            Mile,
            Yard,
            Foot,
            Inch,
            Nautical_mile
        }
    }
}
