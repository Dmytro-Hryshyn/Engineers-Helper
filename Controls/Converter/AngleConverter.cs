﻿using System;
using System.Collections;

namespace Unit.Converter
{
    public class AngleConverter : IConverter
    {
        public decimal FromUnitValue { get; private set; }

        public string FromUnitName { get; private set; }

        public string ToUnitName { get; private set; }

        public string ResultString { get; private set; }

        internal enum AngleUnit
        {

            Degree,
            Radian,
            Gradian
        }

        public AngleConverter(decimal fromUnitValue, string fromUnitName, string toUnitName)
        {
            FromUnitValue = fromUnitValue;
            FromUnitName = fromUnitName;
            ToUnitName = toUnitName;
            ResultString = $"{fromUnitName}-{toUnitName}";
        }

        public string GetUnswer()
        {
            Hashtable angleHash = new Hashtable();
            //Degree to other Unit
            angleHash.Add($"{AngleUnit.Degree}-{AngleUnit.Radian}", FromUnitValue * (decimal)(Math.PI / 180));
            angleHash.Add($"{AngleUnit.Degree}-{AngleUnit.Gradian}", FromUnitValue * (200m / 180m));
            //Radian to other unit
            angleHash.Add($"{AngleUnit.Radian}-{AngleUnit.Degree}", FromUnitValue * (decimal)(180 / Math.PI));
            angleHash.Add($"{AngleUnit.Radian}-{AngleUnit.Gradian}", FromUnitValue * (decimal)(200 / Math.PI));
            //Gradian to other unit
            angleHash.Add($"{AngleUnit.Gradian}-{AngleUnit.Degree}", FromUnitValue * (180m / 200m));
            angleHash.Add($"{AngleUnit.Gradian}-{AngleUnit.Radian}", FromUnitValue * (decimal)(Math.PI / 200));

            if (angleHash.ContainsKey(ResultString))
            {
               return angleHash[ResultString].ToString();
                
            }

            else
            {
                return "0.error";
            }

        }
    }
}
