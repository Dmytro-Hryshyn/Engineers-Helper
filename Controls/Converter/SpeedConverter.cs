using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUiDesign
{
    public class SpeedConverter:IConverter
    {
        public decimal FromUnitValue { get; private set; }

        public string FromUnitName { get; private set; }

        public string ToUnitName { get; private set; }

        public string ResultString { get; private set; }

        public SpeedConverter(decimal fromUnitValue, string fromUnitName, string toUnitName)
        {
            FromUnitValue = fromUnitValue;
            FromUnitName = fromUnitName;
            ToUnitName = toUnitName;
            ResultString = FromUnitName + "_" + toUnitName;
        }

        public string GetUnswer()
        {
            throw new NotImplementedException();
        }
    }

}
