using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLibrary;

namespace AreaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTriangleArea()
        {   //Arrange
            RightTriangle triangle = new RightTriangle() { SideA = 5, SideC = 5 };
            //Act
            double area = Calculate.makeCalculation(triangle);
            //Assert
            Assert.AreEqual(12, area);
        }

        [TestMethod]
        public void TestCircleArea()
        {
            //Arrange
            Circle circle = new Circle() { Radius = 5 };
            //Act
            double area = Calculate.makeCalculation(circle);
            //Assert
            double expected = 78.5398163397448;
            Assert.AreEqual(expected, area, 0.0000001);
        }
    }
}
