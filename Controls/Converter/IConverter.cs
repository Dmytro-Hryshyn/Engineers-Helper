
using System;

namespace ModernUiDesign
{
    public delegate void ErrorCall(string errormess);

    interface IConverter
    {
        
        decimal FromUnitValue { get; }
        string FromUnitName { get; }
        string ToUnitName { get; }
        string ResultString { get; }

         string GetUnswer();
    }
}
