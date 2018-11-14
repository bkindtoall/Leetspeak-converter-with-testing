using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetspeakA;

namespace LeetspeakA.Tests
{
  [TestClass]
  public class LeetspeakClassTest
  {
    [TestMethod]
    public void Leetspeak_e()
    {
        // PingPongClass testPingPong = new PingPongClass();
        Assert.AreEqual('3', LeetspeakClass.CheckNumber('e'));

    }
    [TestMethod]
    public void PingPong_NumberDivisibleByFive_ping()
    {
        // PingPongClass testPingPong = new PingPongClass();
        Assert.AreEqual('0', LeetspeakClass.CheckNumber('o'));

    }
    [TestMethod]
    public void PingPong_NumberDivisibleByThree_pingAndFive_ping()
    {
        // PingPongClass testPingPong = new PingPongClass();
        Assert.AreEqual('7', LeetspeakClass.CheckNumber('t'));

    }
  }
}
