using System;
using System.Linq;
using System.Web.UI;

namespace CFTFTDD.CF.WEB
{
  public partial class PlayerList : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      using (var context = new CFTFTDDEntities())
      {
        var players = context.Players.ToList();

        rpPlayers.DataSource = players;
        rpPlayers.DataBind();
      }
    }
  }
}