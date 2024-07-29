using ST10079970_PROG7312_ICE_Task_1;

namespace Convicts_Indexes_Test
{
    [TestClass]
    public class ConvictUnitTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            int expectedID = 123;
            string expectedName = "John";
            string expectedSurname = "Doe";
            string expectedCrime = "Theft";

            Convict convict = new Convict(expectedID, 5, 101, expectedName, expectedSurname, expectedCrime);

            Assert.AreEqual(expectedID, convict["convictid"]);
            Assert.AreEqual(expectedName, convict["name"]);
            Assert.AreEqual(expectedSurname, convict["surname"]);
            Assert.AreEqual(expectedCrime, convict["crime"]);
        }

        [TestMethod]
        public void TestIndexGet()
        {
            Convict convict = new Convict(123, 5, 101, "John", "Doe", "Theft");

            Assert.AreEqual(123, convict[0]);
            Assert.AreEqual("John", convict[3]);
        }

        [TestMethod]
        public void TestIndexSet()
        {
            Convict convict = new Convict(123, 5, 101, "John", "Doe", "Theft");

            convict[3] = "Jane";
            convict[1] = 10;

            Assert.AreEqual("Jane", convict[3]);
            Assert.AreEqual(10, convict[1]);
        }

        [TestMethod]
        public void TestAttributeNameGet()
        {
            Convict convict = new Convict(123, 5, 101, "John", "Doe", "Theft");

            Assert.AreEqual(123, convict["convictid"]);
            Assert.AreEqual("John", convict["name"]);
        }

        [TestMethod]
        public void TestAttributeNameSet()
        {
            Convict convict = new Convict(123, 5, 101, "John", "Doe", "Theft");

            convict["surname"] = "Smith";
            convict["sentence"] = 7;

            Assert.AreEqual("Smith", convict["surname"]);
            Assert.AreEqual(7, convict["sentence"]);
        }
    }
}