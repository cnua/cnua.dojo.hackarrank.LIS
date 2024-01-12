using Xunit;
using consolehack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolehack.Tests
{
    public class MixrTests
    {
        [Fact()]
        public void MixTest()
        {
            //arrange
            var source = new float[] { 1, 2, 3, -1 };
            var target = new float[] {6 };
            //act
            Mixr.Mix(source, target);
            //Assert
            Assert.True(source.Length == target.Length);
        }
    }
}