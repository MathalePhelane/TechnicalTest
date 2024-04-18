using TS.TechnicalTest;

namespace TS.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class LongestSentanceTests
{
    [TestMethod]
    public void Q1_BasicNominalTest()
    {
        var fakeTextSplitter = new TextSplitter();
        var analyzer = new SentenceAnalyzer(fakeTextSplitter);

        var (sentence, wordCount) = analyzer.FindLongestSentence("We test coders. Give us a try?");

        Assert.AreEqual("Give us a try", sentence.Trim());
        Assert.AreEqual(4, wordCount);
    }
    [TestMethod]
    public void Q2_BasicNominalTest()
    {
        var fakeTextSplitter = new TextSplitter();
        var analyzer = new SentenceAnalyzer(fakeTextSplitter);

        var (sentence, wordCount) = analyzer.FindLongestSentence("Forget CVs..Save time . x x");

        Assert.AreEqual("Forget CVs", sentence.Trim());
        Assert.AreEqual(2, wordCount);
    }
}
