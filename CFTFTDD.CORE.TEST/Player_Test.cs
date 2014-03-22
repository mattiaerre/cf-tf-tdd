using NUnit.Framework;

namespace CFTFTDD.CORE.TEST
{
  [TestFixture]
  public class Player_Test
  {
    [Test]
    public void Lineup_Label_For_Adam_Should_Be_Sharp5_Adam_Bolton()
    {
      // arrange
      var player = new PlayerModel();
      player.FirstName = "Adam";
      player.LastName = "Bolton";
      player.ShirtNumber = 5;
      // act
      var label = player.LineupLabel;
      // assert
      Assert.AreEqual("#5 Adam Bolton", label);
    }

    [Test]
    public void Lineup_Label_For_Lionel_Should_Be_Sharp10_Lionel_Messi()
    {
      // arrange
      var player = new PlayerModel();
      player.FirstName = "Lionel";
      player.LastName = "Messi";
      player.ShirtNumber = 10;
      // act
      var label = player.LineupLabel;
      // assert
      Assert.AreEqual("#10 Lionel Messi", label);
    }
  }
}
