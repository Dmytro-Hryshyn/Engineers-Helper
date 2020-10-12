
using Xunit;
using Geometry;


namespace EngineersHelperTests
{
    public class HelperTests
    {
        [Fact]
        public void IsDefaultValue_shoulPassIfValueIs0()
        {
            double defaultvalue = 0;
            bool actual = defaultvalue.IsDefault();
            Assert.True(actual);

        }
    }
}
