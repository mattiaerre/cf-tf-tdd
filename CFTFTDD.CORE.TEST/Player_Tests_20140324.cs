//using NUnit.Framework;

//namespace CFTFTDD.CORE.TEST
//{
//  [TestFixture]
//  public class Player_Tests_20140324
//  {
//    [Test]
//    public void Lineup_Label_For_Adam_Should_Be_Sharp5_Adam_Bolton()
//    {
//      var player = new PlayerModel();
//      player.FirsName = "Adam";
//      player.LastName = "Bolton";
//      player.ShirtNumber = 5;

//      var lineupLabel = player.LineupLabel;

//      Assert.AreEqual("#5 Adam Bolton", lineupLabel);
//    }

//    [Test]
//    public void Lineup_Label_For_Lionel_Should_Be_Sharp10_Lionel_Messi()
//    {
//      var player = new PlayerModel();
//      player.FirsName = "Lionel";
//      player.LastName = "Messi";
//      player.ShirtNumber = 10;

//      var lineupLabel = player.LineupLabel;

//      Assert.AreEqual("#10 Lionel Messi", lineupLabel);
//    }
//  }

//  public class PlayerModel
//  {
//    public string FirsName { get; set; }
//    public string LastName { get; set; }
//    public int ShirtNumber { get; set; }
//    public string LineupLabel {
//      get { return string.Format("#{0} {1} {2}", ShirtNumber, FirsName, LastName); }
//    }
//  }
//}
