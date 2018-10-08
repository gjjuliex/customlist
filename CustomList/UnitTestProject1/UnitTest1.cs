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
            customList.Remove(value1);

        

            // Assert
            Assert.AreEqual(value1, customList[2]);

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
            customList.Remove(1);
            customList.Remove(2);



            // Assert
            Assert.AreEqual(value2, value3, customList[1]);

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
            customList.Remove(value1);
            customList.Remove(value3);



            // Assert
            Assert.AreEqual(2, 4, customList[3]);

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
            customList.Remove(0);
            customList.Remove(1);



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
            customList.Remove(0);
            customList.Remove(4);



            // Assert
            Assert.AreNotEqual(value2, value4);

        }
        //Overload + Operator//
        [TestMethod]
        public void TestMethodOperatorPlus11()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            list3 = list1 + list2;           
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;
            int value8 = 8;
            


            // Act
            list1.Add(value1);
            list1.Add(value2);
            list1.Add(value3);
            list1.Add(value4);
            list2.Add(value5);
            list2.Add(value6);
            list2.Add(value7);
            list2.Add(value8);
            expectedList = list1 + list2;



            // Assert
            Assert.AreEqual(list3, expectedList);

        }
        //Overload + Operator//
        [TestMethod]
        public void TestMethodOperatorPlus12()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            list3 = list1 + list2;
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;
            int value8 = 8;



            // Act
            list1.Add(value1);
            list1.Add(value2);
            list1.Add(value3);
            list1.Add(value4);
            list2.Add(value5);
            list2.Add(value6);
            list2.Add(value7);
            list2.Add(value8);
            expectedList = list1 + list2;



            // Assert
            Assert.AreNotEqual(list2, expectedList);

        }
        //Overload + Operator//
        [TestMethod]
        public void TestMethodOperatorPlus13()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            CustomList<int> actualList = new CustomList<int>();
            CustomList<int> list4 = new CustomList<int>();
            CustomList<int> list5 = new CustomList<int>();
            list3 = list1 + list2;
            list4 = list3 + list1;
            list5 = list4 + list2;
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;
            int value8 = 8;



            // Act
            list1.Add(value1);
            list1.Add(value2);
            list1.Add(value3);
            list1.Add(value4);
            list2.Add(value5);
            list2.Add(value6);
            list2.Add(value7);
            list2.Add(value8);
            actualList = list1 + list2 + list1 + list2;
            resultList = list5; 
        



            // Assert
            Assert.AreEqual(resultList, actualList);

        }
        //Overload + Operator//
        [TestMethod]
        public void TestMethodOperatorPlus14()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            CustomList<int> actualList = new CustomList<int>();
            CustomList<int> list4 = new CustomList<int>();
            CustomList<int> list5 = new CustomList<int>();
            list3 = list1 + list2;
            list4 = list3 + list1;
            list5 = list4 + list2;
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;
            int value8 = 8;



            // Act
            list1.Add(value1);
            list1.Add(value2);
            list1.Add(value3);
            list1.Add(value4);
            list2.Add(value5);
            list2.Add(value6);
            list2.Add(value7);
            list2.Add(value8);
            actualList = list2 + list1 + list2 + list1;
            resultList = list5;




            // Assert
            Assert.AreNotEqual(resultList, actualList);

        }
        //Overload + Operator//
        [TestMethod]
        public void TestMethodOperatorPlus15()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            CustomList<int> actualList = new CustomList<int>();
            CustomList<int> list4 = new CustomList<int>();
            CustomList<int> list5 = new CustomList<int>();
            list3 = list1 + list2;
            list5 = list3 + list4;

            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;
            int value8 = 8;



            // Act
            list1.Add(value1);
            list1.Add(value2);
            list1.Add(value3);
            list1.Add(value4);
            list2.Add(value5);
            list2.Add(value6);
            list2.Add(value7);
            list2.Add(value8);
            list4.Add(value1);
            list4.Add(value2);
            list4.Add(value3);
            actualList = list1 + list2 + list4;
            resultList = list5;




            // Assert
            Assert.AreEqual(resultList, actualList);

        }
    }
}
