using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAdd1()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 2;

            // Act
            customList.Add(value);

            //Assert      
            Assert.AreEqual(value, customList[0]);
        }
        [TestMethod]
        public void TestMethodAdd2()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 2;
            int value1 = 4;

            // Act
            customList.Add(value);
            customList.Add(value1);

            // Assert
            Assert.AreEqual(value1, customList[1]);

        }
        [TestMethod]
        public void TestMethodAdd3()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 2;
            int value1 = 4;
            int value2 = 6;

            // Act
            customList.Add(value);
            customList.Add(value1);
            customList.Add(value2);

            // Assert
            Assert.AreEqual(value2, customList[2]);

        }
        [TestMethod]
        public void TestMethodAdd4()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 2;
            int value1 = 4;
            int value2 = 6;
            int value3 = 8;

            // Act
            customList.Add(value);
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);

            // Assert
            Assert.AreEqual(value3, customList[3]);

        }
        [TestMethod]
        public void TestMethodAdd5()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 2;
            int value1 = 4;
            int value2 = 6;
            int value3 = 8;
            int value4 = 10;

            // Act
            customList.Add(value);
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);

            // Assert
            Assert.AreEqual(value4, customList[4]);

        }
        //REMOVE//
        [TestMethod]
        public void TestMethodRemove6()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();           
            int value1 = 4;
            int value2 = 5;
            int value3 = 6;



            // Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.RemoveAt(value1);

        

            // Assert
            Assert.IsTrue(value1, customList[3]);

        }
        [TestMethod]
        public void TestMethodRemove7()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 4;
            int value2 = 5;
            int value3 = 6;



            // Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.RemoveAt(1);
            customList.RemoveAt(2);



            // Assert
            Assert.IsTrue(value1,value2, customList[1]);

        }
        [TestMethod]
        public void TestMethodRemove8()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 4;
            int value2 = 5;
            int value3 = 6;
            int value4 = 7;
            int value5 = 8;



            // Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.RemoveAt(1);
            customList.RemoveAt(3);



            // Assert
            Assert.IsTrue(value2,value4,customList[3]);

        }
        [TestMethod]
        public void TestMethodRemove9()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 4;
            int value2 = 5;
            int value3 = 6;
            int value4 = 7;
            int value5 = 8;



            // Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.RemoveAt(0);
            customList.RemoveAt(1);



            // Assert
            Assert.AreEqual(value3, customList[0]);

        }
        [TestMethod]
        public void TestMethodRemove10()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 5;
            int value3 = 3;
            int value4 = 5;
            int value5 = 4;



            // Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.RemoveAt(0);
            customList.RemoveAt(4);



            // Assert
            Assert.AreNotEqual(value2, value4);

        }
    }
}
