using System;
using System.IO;
using HelloWorld;
using Xunit;

namespace HelloWorldTests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_WritesHelloWorldToConsole()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            Program.Main(new string[] {});

            var result = stringWriter.ToString().Trim();

            Assert.Equal("Hello, World!", result);
        }
    }
}
