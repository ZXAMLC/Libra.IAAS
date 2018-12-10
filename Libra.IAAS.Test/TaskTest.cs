
using System;
using Xunit;

using Libra.IAAS;

namespace Libra.IAAS.Test
{
    public class TaskTest
    {
        [Fact]
        public void TaskHelloSayHello()
        {
            var result = new Task().Hello();

            Assert.Equal("HelloWorld", result);
        }
    }
}
