//using System.Linq;
//using CFTFTDD.CF.WEB;
//using NUnit.Framework;

//namespace CFTFTDD.WEB.TEST
//{
//  [TestFixture]
//  public class Player_Tests_20140324
//  {
//    [Test]
//    public void FirstName_Adam_LastName_Bolton_Should_Return_Adam_Bolton()
//    {
//      using (var context = new CFTFTDDEntities())
//      {
//        var entity = context.Players.First(e => e.FirstName == "Adam");

//        var player = new PlayerModel();
//        player.FirstName = entity.FirstName;
//        player.LastName = entity.LastName;

//        Assert.AreEqual("Adam Bolton", player.FullName);
//      }
//    }

//    [Test]
//    public void FirstName_Lionel_LastName_Messi_Should_Return_Lionel_Messi()
//    {
//      using (var context = new CFTFTDDEntities())
//      {
//        var entity = context.Players.First(e => e.FirstName == "Lionel");

//        var player = new PlayerModel();
//        player.FirstName = entity.FirstName;
//        player.LastName = entity.LastName;

//        Assert.AreEqual("Lionel Messi", player.FullName);
//      }
//    }
//  }

//  public class PlayerModel : Player
//  {
//    public string FullName {
//      get { return string.Format("{0} {1}", FirstName, LastName); }
//    }
//  }
//}
