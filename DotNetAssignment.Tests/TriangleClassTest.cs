using DotNetAssignment.Classes;
using Xunit;

namespace DotNetAssignment.Tests
{
    public class TriangleClassTests
    {
        [Theory]
        [InlineData(3, 4, 5, true)]   // Right triangle (3-4-5)
        [InlineData(5, 12, 13, true)] // Right triangle (5-12-13)
        [InlineData(8, 15, 17, true)] // Right triangle (8-15-17)
        [InlineData(3, 4, 6, false)]  // Not a right triangle
        [InlineData(0, 0, 0, false)]  // Not a right triangle (all sides are 0)

        public void IsRightTriangle_ShouldReturnCorrectResult(double sideA, double sideB, double sideC, bool expectedResult)
        {
            // Arrange
            var triangle = new TriangleClass {
                SideA = sideA,
                SideB = sideB,
                SideC = sideC
            };
            var triangleClass = new TriangleClass();

            // Act
            var result = triangleClass.IsRightTriangle(triangle);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
