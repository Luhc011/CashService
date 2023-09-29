using MoneyExtension;

namespace MoneyExtensionTests
{
    public class MoneyExtensionTests
    {
        [Fact]
        public void ShouldConvertDecimalToInt()
        {
            decimal valor = 112.23m;
            var cents = valor.ToCents();
            Assert.Equal(11223, cents);
        }
    }
}
