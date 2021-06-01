using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Rotation.Rotation;

namespace RotationTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void IsRotationString_water_terwa_ReturnedTrue()
        {
            //arrange
            string str = "water";
            string substr = "terwa";
            bool expected = true;

            //act
            bool actual = IsRotationString(str, substr);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRotationString_empty_terwa_ReturnedFalse()
        {
            //arrange
            string str = "";
            string substr = "terwa";
            bool expected = false;

            //act
            bool actual = IsRotationString(str, substr);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRotationString_water_ertwa_ReturnedFalse()
        {
            //arrange
            string str = "water";
            string substr = "ertwa";
            bool expected = false;

            //act
            bool actual = IsRotationString(str, substr);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRotationString_null_ertwa_ThrowArgumentNullException()
        {
            //arrange
            string str = null;
            string substr = "aaa";

            //act + assert
            Assert.ThrowsException<ArgumentNullException>(() => IsRotationString(str, substr));
        }
    }
}