using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongA;

namespace PingPongA.Tests
{
  [TestClass]
  public class PingPongClassTest
  {
    [TestMethod]
    public void PingPong_NumberDivisibleByThree_ping()
    {
        // PingPongClass testPingPong = new PingPongClass();
        Assert.AreEqual("ping", PingPongClass.CheckNumber(6));

    }
    [TestMethod]
    public void PingPong_NumberDivisibleByFive_ping()
    {
        // PingPongClass testPingPong = new PingPongClass();
        Assert.AreEqual("pong", PingPongClass.CheckNumber(5));

    }
    [TestMethod]
    public void PingPong_NumberDivisibleByThree_pingAndFive_ping()
    {
        // PingPongClass testPingPong = new PingPongClass();
        Assert.AreEqual("ping-pong", PingPongClass.CheckNumber(15));

    }
  }
}
