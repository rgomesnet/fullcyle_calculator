using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var resultado = App.Program.Soma(1, 2);
            Assert.Equal(3, resultado);
        }
    }
}