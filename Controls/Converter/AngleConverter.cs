using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUiDesign.Controls.Converter
{
    public class AngleConverter : IConverter
    {
        public decimal FromUnitValue { get; private set; }

        public string FromUnitName { get; private set; }

        public string ToUnitName { get; private set; }

        public string ResultString { get; private set; }

        public string GetUnswer()
        {
            throw new NotImplementedException();
        }
    }
}
