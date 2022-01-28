using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moodanalyser;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    { 
    MoodAnalyser  moodAnalyser;
    string message = " I am in happy Mood";

    [TestInitialize]
    public void SetUp()
    {
        moodAnalyser = new MoodAnalyser(message);
    }
    
        [TestMethod]
        public void TestMethodHappy()
        {
        string expected = "happy";

        string actual = moodAnalyser.AnalyzeMood();
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethodSad()
    
    {
        string expected = "sad";
        MoodAnalyser moodAnalyser = new MoodAnalyser("I am in sad Mood");
        string actual = moodAnalyser.AnalyzeMood();
        Assert.AreEqual(expected, actual);
    }
}
    }
