using prjILieToSirAboutUnitTesting;

namespace TestIWantANewProgLecturer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestgetName()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getName();
            String Expected = "Jeff";
            Assert.AreEqual(Actual, Expected);
        }
        [TestMethod]
        public void TestGetEmail()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getEmail();
            String Expected = "jess@gmail.com";
            Assert.AreEqual(Actual, Expected);
        }
        [TestMethod]
        public void TestGetDate()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getDate();
            String Expected = "2024/04/04";
            Assert.AreEqual(Actual, Expected);

        }
    }
}