using System;
using System.Collections;

namespace ModernUiDesign
{
    public class AngleConverter : IConverter
    {
        public decimal FromUnitValue { get; private set; }

        public string FromUnitName { get; private set; }

        public string ToUnitName { get; private set; }

        public string ResultString { get; private set; }

        enum AngleUnit { Degree, Radian, Gradian }

        public AngleConverter(decimal fromUnitValue, string fromUnitName, string toUnitName)
        {
            FromUnitValue = fromUnitValue;
            FromUnitName = fromUnitName;
            ToUnitName = toUnitName;
            ResultString = $"{FromUnitName}-{toUnitName}";
        }


        public string GetUnswer()
        {
            Hashtable hashtable = new Hashtable();
            //Degree to another Unit
            hashtable.Add($"{AngleUnit.Degree}-{AngleUnit.Radian}", FromUnitValue * (decimal)(Math.PI / 180));
            hashtable.Add($"{AngleUnit.Degree}-{AngleUnit.Gradian}", FromUnitValue * (200m / 180m));
            //Radian to another Unit
            hashtable.Add($"{AngleUnit.Radian}-{AngleUnit.Degree}", FromUnitValue * (decimal)(180 / Math.PI));
            hashtable.Add($"{AngleUnit.Radian}-{AngleUnit.Gradian}", FromUnitValue * (decimal)(200 / Math.PI));
            //Gradian to another Unit
            hashtable.Add($"{AngleUnit.Gradian}-{AngleUnit.Radian}", FromUnitValue * (decimal)(Math.PI / 200 ));
            hashtable.Add($"{AngleUnit.Gradian}-{AngleUnit.Degree}", FromUnitValue * (180m / 200m));

            if (hashtable.ContainsKey(ResultString))
            {
                return hashtable[ResultString].ToString();
            }

            else return "0.error";
        }
    }

}