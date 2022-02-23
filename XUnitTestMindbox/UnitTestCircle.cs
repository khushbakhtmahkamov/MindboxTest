using System;
using Xunit;
using TestMindbox.Repositorys;
using Moq;
using Microsoft.Extensions.Logging;

namespace XUnitTestMindbox
{
    public class UnitTestCircle
    {
        private IGeometryRepository geometryRepository = new GeometryRepository();


        [Fact]
        public void IsCircleAreaCorrect()
        {
            Assert.Equal(Math.PI, geometryRepository.GetAteaCircle(1));
            Assert.Equal(Math.PI * 4, geometryRepository.GetAteaCircle(2));
        }

        [Fact]
        public void IsInputValid()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => geometryRepository.GetAteaCircle(-10));
            Assert.Throws<ArgumentOutOfRangeException>(() => geometryRepository.GetAteaCircle(0));
        }
    }
}
