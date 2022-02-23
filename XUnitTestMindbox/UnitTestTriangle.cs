using System;
using Xunit;
using TestMindbox.Repositorys;
using Moq;
using Microsoft.Extensions.Logging;

namespace XUnitTestMindbox
{
    public class UnitTestTriangle
    {
        private IGeometryRepository geometryRepository = new GeometryRepository();


        [Fact]
        public void IsTriangleAreaCorrect()
        {
            Assert.Equal(6.0, geometryRepository.GetAteaTriangle(3, 4, 5));
        }

        [Fact]
        public void IsInputValid()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => geometryRepository.GetAteaTriangle(-1, 1, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => geometryRepository.GetAteaTriangle(1, -1, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => geometryRepository.GetAteaTriangle(1, 1, -1));
        }

        [Fact]
        public void IsRight_Correct()
        {
            Assert.True(geometryRepository.IsRightTriangle(3, 4, 5));
            Assert.False(geometryRepository.IsRightTriangle(2, 3, 6));
        }
    }
}
