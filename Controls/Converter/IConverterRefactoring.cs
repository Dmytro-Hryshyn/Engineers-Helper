using System.Collections.Generic;

namespace Unit.Converter
{
    interface IConverterRefactoring
    {
         public decimal ConvertUnit();

         public Dictionary<string, decimal> CreateDictinary();
    }
}
