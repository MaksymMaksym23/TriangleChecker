using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TrianglesChecker
{
    [TestFixture]
    class TestProgram
    {
        [Test]
        public void Test_Equilateral222()
        {
            Assert.AreEqual(TriangleTypes.Equilateral,
                new Program().CheckTriangleType(2, 2, 2));
        }

        #region negative test cases
        [Test]
        public void Test_ErrorNegative()
        {
            Assert.AreEqual(TriangleTypes.Error,
                new Program().CheckTriangleType(-3, 2, 4));
        }

        [Test]
        public void Test_ErrorZero1()
        {
            Assert.AreEqual(TriangleTypes.Error,
                new Program().CheckTriangleType(2, 0, 4));
        }
        [Test]
        public void Test_ErrorZero2()
        {
            Assert.AreEqual(TriangleTypes.Error,
                new Program().CheckTriangleType(2, 1, 0));
        }

        [Test]
        public void Test_Error_C_isBigger()
        {
            Assert.AreEqual(TriangleTypes.Error,
                new Program().CheckTriangleType(5, 5, 12));
        }

        [Test]
        public void Test_Error_A_isBigger()
        {
            Assert.AreEqual(TriangleTypes.Error,
                new Program().CheckTriangleType(11, 5, 4));
        }

        [Test]
        public void Test_Error_B_Equal()
        {
            Assert.AreEqual(TriangleTypes.Error,
                new Program().CheckTriangleType(11, 15, 4));
        }
        #endregion

        #region Isosceles test cases
        [Test]
        public void Test_Isosceles_BA()
        {
            Assert.AreEqual(TriangleTypes.Isosceles,
                new Program().CheckTriangleType(11, 11, 5));
        }

        [Test]
        public void Test_Isosceles_CA()
        {
            Assert.AreEqual(TriangleTypes.Isosceles,
                new Program().CheckTriangleType(5, 4, 5));
        }

        [Test]
        public void Test_Isosceles_BC()
        {
            Assert.AreEqual(TriangleTypes.Isosceles,
                new Program().CheckTriangleType(3, 5, 5));
        }
        #endregion

        [Test]
        public void Test_Scalene()
        {
            Assert.AreEqual(TriangleTypes.Scalene,
                new Program().CheckTriangleType(3, 4, 2));
        }
    }
}
