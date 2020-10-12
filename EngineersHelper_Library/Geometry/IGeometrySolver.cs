using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Helper
{
    interface IGeometrySolver
    {
        void SetKnownProperties();
        void Solve();
    }
}
